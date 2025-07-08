using AForge.Video;
using AForge.Video.DirectShow;
using Core.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace ControlDeAccesosDesktop
{
    public partial class PanelAcceso : Form
    {
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection dispositivosVideo;
        private string tipo;
        private Guardia guardia;

        public PanelAcceso(string tipo, Guardia guardia)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.guardia = guardia;
            if (tipo.Equals("Entrada"))
            {
                btnSalida.Visible = false;
            }
            else
            {
                btnEntrada.Visible = false;
            }
            btnEntrada.Enabled = false;
            btnSalida.Enabled = false;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
                pictureBoxVideo.Image = (Bitmap)imagen.Clone();

                var lector = new BarcodeReader();
                var resultado = lector.Decode(imagen);

                if (resultado != null)
                {
                    videoSource.SignalToStop();

                    this.Invoke(new Action(() =>
                    {
                        txtCodigoQR.Text = resultado.Text;
                        ProcesarCodigoQR(resultado.Text);
                    }));
                }
            }
            catch { }
        }

        private void ProcesarCodigoQR(string codigoQR)
        {
            using var context = new ControlDbContext();
            context.Residentes.Load();

            var residente = context.Residentes.FirstOrDefault(r => r.CodigoQR == codigoQR);
            if (residente != null)
            {
                MostrarInfoResidente(residente);
                return;
            }

            var invitado = context.Invitados
                .Include(i => i.Residente)
                .FirstOrDefault(i => i.CodigoQR == codigoQR);

            if (invitado != null)
            {
                if (invitado.TipoInvitacion == TipoInvitacion.PorFecha)
                {
                    if (invitado.FechaInicioValidez == null || invitado.FechaFinValidez == null)
                    {
                        MostrarMensaje("Fechas inválidas para invitado por fecha", Color.Red);
                        return;
                    }

                    var hoy = DateTime.Today;
                    if (invitado.FechaInicioValidez > hoy || invitado.FechaFinValidez < hoy)
                    {
                        MostrarMensaje("Invitación vencida", Color.Red);
                        return;
                    }
                }

                MostrarInfoInvitado(invitado);
                return;
            }

            MostrarMensaje("QR inválido o no registrado", Color.Red);
        }

        private void MostrarInfoResidente(Residente r)
        {
            lblID.Text = $"ID: {r.Id}";
            lblNombre.Text = $"Nombre: {r.Nombre} {r.Apellidos}";
            lblResidente.Text = "";
            pbFoto.Image = r.Foto != null ? Image.FromStream(new MemoryStream(r.Foto)) : null;
            btnEntrada.Enabled = true;
            btnSalida.Enabled = true;
            txtCodigoQR.Tag = r;
            MostrarMensaje("Residente reconocido", Color.Green);
        }

        private void MostrarInfoInvitado(Invitado i)
        {
            lblID.Text = $"ID: {i.Id}";
            lblNombre.Text = $"Nombre: {i.Nombre} {i.Apellidos}";
            lblResidente.Text = $"Invitado por: {i.Residente?.Nombre} {i.Residente?.Apellidos}";
            pbFoto.Image = null;
            btnEntrada.Enabled = true;
            btnSalida.Enabled = true;
            txtCodigoQR.Tag = i;
            MostrarMensaje("Invitado válido", Color.Green);
        }

        private void MostrarMensaje(string mensaje, Color color)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = color;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            RegistrarAcceso(TipoAcceso.Entrada);
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            RegistrarAcceso(TipoAcceso.Salida);
        }

        private void RegistrarAcceso(TipoAcceso tipo)
        {
            using var context = new ControlDbContext();
            var codigoQR = txtCodigoQR.Text.Trim();
            var fecha = DateTime.Now;

            var residente = context.Residentes.FirstOrDefault(r => r.CodigoQR == codigoQR);
            var invitado = context.Invitados.FirstOrDefault(i => i.CodigoQR == codigoQR);

            if (residente == null && invitado == null)
            {
                MostrarMensaje("Entidad no reconocida.", Color.Red);
                return;
            }

            var ultimoAcceso = context.RegistrosAcceso
                .Where(r =>
                    (residente != null && r.ResidenteId == residente.Id) ||
                    (invitado != null && r.InvitadoId == invitado.Id))
                .OrderByDescending(r => r.FechaHora)
                .FirstOrDefault();

            if (ultimoAcceso != null && ultimoAcceso.TipoAcceso == tipo)
            {
                MostrarMensaje($"Ya se registró una {tipo.ToString().ToLower()}.", Color.Orange);
                return;
            }

            var nuevo = new RegistroAcceso
            {
                FechaHora = fecha,
                TipoAcceso = tipo,
                GuardiaId = guardia.Id,
                ResidenteId = residente?.Id,
                InvitadoId = invitado?.Id,
                Notas = txtNotas.Text.Trim() == "" ? null : txtPlacas.Text.Trim(),
                PlacasVehiculo = txtPlacas.Text.Trim() == "" ? null : txtPlacas.Text.Trim()
            };

            context.RegistrosAcceso.Add(nuevo);
            context.SaveChanges();

            MostrarMensaje($"Acceso de {tipo} registrado", Color.Blue);
            btnEntrada.Enabled = false;
            btnSalida.Enabled = false;
        }

        private void PanelAcceso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
                videoSource.SignalToStop();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
                videoSource.SignalToStop();
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }

        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosVideo.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna cámara.");
                return;
            }

            videoSource = new VideoCaptureDevice(dispositivosVideo[0].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;
            videoSource.Start();

        }

        private void PanelAcceso_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}



