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
        private byte[] fotoSeleccionada = null;

        public RegistroResidentes(Residente residente)
        {
            InitializeComponent();
            this.residente = residente;
            if(residente == null)
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
                    txtDomicilio.Text = residente.Domicilio;
                    
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
    }
}
