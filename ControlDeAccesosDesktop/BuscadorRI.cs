using Core.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
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

    public partial class BuscadorRI : Form
    {

        private Guardia guardia;

        private Residente residenteEncontrado;

        public BuscadorRI(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }
        private void BuscadorRI_Load(object sender, EventArgs e)
        {
            gbReIn.Visible = false;

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            gbReIn.Visible = true;

            using (var context = new ControlDbContext())
            {
                string nombre = txtNombre.Text.Trim().ToLower();
                string direccion = txtDomicilio.Text.Trim().ToLower();

                residenteEncontrado = context.Residentes
                        .Include(r => r.Vehiculos)
                        .FirstOrDefault(r =>
                            (!string.IsNullOrEmpty(nombre) &&
                             (r.Nombre + " " + r.Apellidos).ToLower().Contains(nombre)) ||
                            (!string.IsNullOrEmpty(direccion) &&
                             r.Domicilio.ToLower().Contains(direccion))
                        );

                if (residenteEncontrado != null)
                {
                    lblNombre.Text = residenteEncontrado.Nombre + " " + residenteEncontrado.Apellidos;
                    lblTipo.Text = "Residente";

                    // Vehículos
                    dgvVehiculos.DataSource = residenteEncontrado.Vehiculos
                        .Select(v => new { v.Marca, v.Modelo, v.Placas }).ToList();

                    // Foto (BLOB → Image)
                    if (residenteEncontrado.Foto != null && residenteEncontrado.Foto.Length > 0)
                    {
                        using (var ms = new MemoryStream(residenteEncontrado.Foto))
                        {
                            pbFoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbFoto.Image = null;
                    }

                    btnActualizar.Enabled = true;
                    btnActualizar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Residente no encontrado.");
                    LimpiarCampos();
                }
            }
        }
        private void LimpiarCampos()
        {
            lblNombre.Text = "";
            lblTipo.Text = "";
            dgvVehiculos.DataSource = null;
            residenteEncontrado = null;
        }
        private void btnregresar_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(guardia);
            nuevaVentana.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtDomicilio.Enabled = string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Escribe el nombre.";
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = string.IsNullOrWhiteSpace(txtDomicilio.Text) || txtDomicilio.Text == "Escribe el domicilio.";
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(guardia);
            nuevaVentana.Show();
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (residenteEncontrado != null)
            {
                var ventana = new RegistroResidentes(residenteEncontrado, guardia);
                ventana.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Primero realiza una búsqueda válida.");
            }
        }

        private void BuscadorRI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Escribe el nombre.")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Escribe el nombre.";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtDomicilio_Click(object sender, EventArgs e)
        {
            if (txtDomicilio.Text == "Escribe el domicilio.")
            {
                txtDomicilio.Text = "";
                txtDomicilio.ForeColor = Color.Black;
            }
        }

        private void txtDomicilio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                txtDomicilio.Text = "Escribe el domicilio.";
                txtDomicilio.ForeColor = Color.Gray;
            }
        }
    }
}
