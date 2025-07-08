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
    public partial class HistorialES : Form
    {
        public Guardia GuardiaLogueado { get; set; }
        public HistorialES(Guardia guardia)
        {
            InitializeComponent();
            GuardiaLogueado = guardia;
            lblGuardiaActual.Text = $"Consulta hecha por: {GuardiaLogueado.Nombre}";
            cmbTipoPersona.SelectedIndex = 0;
            cmbTipoAcceso.SelectedIndex = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(GuardiaLogueado);
            nuevaVentana.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            string tipoPersona = cmbTipoPersona.SelectedItem.ToString();
            string tipoAcceso = cmbTipoAcceso.SelectedItem.ToString();

            using (var context = new ControlDbContext())
            {
                var query = context.RegistrosAcceso
                    .Include(r => r.Residente)
                    .Include(r => r.Invitado).ThenInclude(i => i.Residente)
                    .Include(r => r.Guardia)
                    .AsQueryable();

                // Filtro por fecha
                query = query.Where(r => r.FechaHora.Date == fechaSeleccionada);

                // Filtro por tipo de persona
                if (tipoPersona == "Residente")
                    query = query.Where(r => r.ResidenteId != null);
                else if (tipoPersona == "Invitado")
                    query = query.Where(r => r.InvitadoId != null);

                // Filtro por tipo de acceso
                if (tipoAcceso == "Entrada")
                    query = query.Where(r => r.TipoAcceso == TipoAcceso.Entrada);
                else if (tipoAcceso == "Salida")
                    query = query.Where(r => r.TipoAcceso == TipoAcceso.Salida);

                var resultados = query.Select(r => new
                {
                    Fecha = r.FechaHora.ToString("dd/MM/yyyy"),
                    Hora = r.FechaHora.ToString("HH:mm"),
                    TipoAcceso = r.TipoAcceso.ToString(),
                    TipoPersona = r.ResidenteId != null ? "Residente" : "Invitado",
                    Nombre = r.ResidenteId != null
                        ? r.Residente.Nombre + " " + r.Residente.Apellidos
                        : r.Invitado.Nombre + " " + r.Invitado.Apellidos,
                    InvitadoPor = r.InvitadoId != null
                        ? r.Invitado.Residente.Nombre + " " + r.Invitado.Residente.Apellidos
                        : "-",
                    Guardia = r.Guardia.Nombre
                })
                .ToList();

                dgvHistorial.DataSource = resultados;
            }
        }
    }
}
