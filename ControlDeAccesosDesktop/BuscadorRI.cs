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
        public string TipoPersona { get; internal set; }

        public BuscadorRI()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            gbReIn.Visible = true;

            using (var context = new ControlDbContext())
            {
                string nombre = txtNombre.Text.Trim().ToLower();
                string direccion = txtDomicilio.Text.Trim().ToLower();

                if (TipoPersona == "Residente")
                {
                    var residente = context.Residentes
                        .Include(r => r.Vehiculos)
                        .FirstOrDefault(r =>
                            (!string.IsNullOrEmpty(nombre) &&
                             (r.Nombre + " " + r.Apellidos).ToLower().Contains(nombre)) ||
                            (!string.IsNullOrEmpty(direccion) &&
                             r.Domicilio.ToLower().Contains(direccion))
                        );

                    if (residente != null)
                    {
                        lblNombre.Text = residente.Nombre + " " + residente.Apellidos;
                        lblTipo.Text = "Residente";

                        var vehiculo = residente.Vehiculos.FirstOrDefault();
                        if (vehiculo != null)
                        {
                            lblMarca.Text = vehiculo.Marca;
                            lblModelo.Text = vehiculo.Modelo;
                            lblPlaca.Text = vehiculo.Placas;
                        }
                        else
                        {
                            lblMarca.Text = "Sin vehículo";
                            lblModelo.Text = "-";
                            lblPlaca.Text = "-";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Residente no encontrado.");
                        LimpiarLabels();
                    }
                }
                else if (TipoPersona == "Invitado")
                {
                    var invitado = context.Invitados
                        .FirstOrDefault(i =>
                            (!string.IsNullOrEmpty(nombre) &&
                             (i.Nombre + " " + i.Apellidos).ToLower().Contains(nombre))
                        );

                    if (invitado != null)
                    {
                        lblNombre.Text = invitado.Nombre + " " + invitado.Apellidos;
                        lblTipo.Text = "Invitado";
                        lblMarca.Text = "No aplica";
                        lblModelo.Text = "No aplica";
                        lblPlaca.Text = "No aplica";
                    }
                    else
                    {
                        MessageBox.Show("Invitado no encontrado.");
                        LimpiarLabels();
                    }
                }
            }
        }

        private void LimpiarLabels()
        {
            lblNombre.Text = "";
            lblTipo.Text = "";
            lblMarca.Text = "";
            lblModelo.Text = "";
            lblPlaca.Text = "";
        }


        private void BuscadorRI_Load(object sender, EventArgs e)
        {
            gbReIn.Visible = false;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Buscar nuevaVentana = new Buscar();
            nuevaVentana.Show();
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtDomicilio.Enabled = string.IsNullOrWhiteSpace(txtNombre.Text);
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = string.IsNullOrWhiteSpace(txtDomicilio.Text);
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            Buscar nuevaVentana = new Buscar();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
