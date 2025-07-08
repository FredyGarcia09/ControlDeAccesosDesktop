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
    
    public partial class AgregarVehiculos : Form
    {
        private Guardia guardia;
        public AgregarVehiculos(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbResidentes.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un residente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtPlacas.Text))
            {
                MessageBox.Show("Llena todos los campos del vehículo.");
                return;
            }

            int residenteId = (int)cmbResidentes.SelectedValue;

            using (var context = new ControlDbContext())
            {
                var nuevoVehiculo = new Vehiculo
                {
                    Marca = txtMarca.Text.Trim(),
                    Modelo = txtModelo.Text.Trim(),
                    Placas = txtPlacas.Text.Trim(),
                    ResidenteId = residenteId
                };

                context.Vehiculos.Add(nuevoVehiculo);
                context.SaveChanges();
            }

            MessageBox.Show("Vehículo registrado con éxito.");
            LimpiarCampos();
        }

        private void AgregarVehiculos_Load(object sender, EventArgs e)
        {
            using (var context = new ControlDbContext())
            {
                var residentes = context.Residentes
                    .Select(r => new ResidenteCombo
                    {
                        Id = r.Id,
                        Display = r.Nombre + " " + r.Apellidos + " | " + r.Domicilio
                    })
                    .ToList();

                cmbResidentes.DataSource = residentes;
                cmbResidentes.DisplayMember = "Display";
                cmbResidentes.ValueMember = "Id";
            }
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlacas.Clear();
            cmbResidentes.SelectedIndex = -1;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }
    }

    public class ResidenteCombo
    {
        public int Id { get; set; }
        public string Display { get; set; }
    }
}
