using Core.Models;
using DataAccess.Data;
using System.IO;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAccesosDesktop
{
    public partial class RegistroResidentes : Form
    {
        private Residente residente;
        private Guardia guardia;
        private byte[] fotoSeleccionada = null;

        public RegistroResidentes(Residente residente, Guardia guardia)
        {
            InitializeComponent();
            this.residente = residente;
            this.guardia = guardia;
            if (residente == null)
            {
                btnAgregar.Visible = true;
                btnGuardarCambios.Visible = false;
                lblContrasena.Visible = false;
                txtContrasena.Visible = false;
            }
            else
            {
                btnAgregar.Visible = false;
                btnGuardarCambios.Visible = true;
                lblContrasena.Visible = true;
                txtContrasena.Visible = true;
                CargarDatosResidente();
            }
        }

        private void CargarDatosResidente()
        {
            using (var context = new ControlDbContext())
            {
                var residenteDb = context.Residentes
                    .Include(r => r.Domicilio)
                    .FirstOrDefault(r => r.Id == residente.Id);
                if (residenteDb != null)
                {
                    txtNombre.Text = residenteDb.Nombre;
                    txtApellidos.Text = residenteDb.Apellidos;
                    txtTelefono.Text = residenteDb.Telefono;
                    txtDomicilio.Text = residenteDb.Domicilio;

                    if (residenteDb.Foto != null)
                    {
                        fotoSeleccionada = residenteDb.Foto;
                        using (var ms = new MemoryStream(fotoSeleccionada))
                        {
                            pbFoto.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecciona una foto del residente";
            openFileDialog.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guarda la imagen como un arreglo
                fotoSeleccionada = File.ReadAllBytes(openFileDialog.FileName);

                // Enseña la imagen en el PictureBox
                using (var ms = new MemoryStream(fotoSeleccionada))
                {
                    pbFoto.Image = Image.FromStream(ms);
                }

            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoResidente = new Residente
            {
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Domicilio = txtDomicilio.Text,
                Telefono = txtTelefono.Text,
                ContrasenaHash = txtContrasena.Text,
                CodigoQR = GenerarCodigoQR(),
                Foto = fotoSeleccionada,
                Vehiculos = new List<Vehiculo>(),
                Invitados = new List<Invitado>(),
                RegistrosAcceso = new List<RegistroAcceso>()
            };

            using var context = new ControlDbContext();
            context.Residentes.Add(nuevoResidente);
            await context.SaveChangesAsync();

            MessageBox.Show("Residente registrado con éxito.");
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }

        private string GenerarCodigoQR()
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string codigo;

            using (var context = new ControlDbContext())
            {
                do
                {
                    // Genera una cadena aleatoria de 16 caracteres
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 16; i++)
                    {
                        sb.Append(caracteres[random.Next(caracteres.Length)]);
                    }
                    codigo = sb.ToString();

                    // Verifica que no exista
                } while (context.Residentes.Any(r => r.CodigoQR == codigo) ||
                         context.Invitados.Any(i => i.CodigoQR == codigo));
            }

            return codigo;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }
    }
}
