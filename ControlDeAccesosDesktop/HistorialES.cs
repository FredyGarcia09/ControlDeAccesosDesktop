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
        public HistorialES()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial();
            nuevaVentana.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new ControlDbContext())
            {
                var fechaSeleccionada = dateTimePicker1.Value.Date;

                // Traemos todos los accesos del día, con datos relacionados
                var registrosDelDia = context.RegistrosAcceso
                    .Include(r => r.Residente)
                    .Include(r => r.Invitado)
                    .Include(r => r.PlacasVehiculo)
                    .Where(r => r.FechaHora.Date == fechaSeleccionada)
                    .ToList();

                // Agrupar por persona (Residente o Invitado) y vehículo
                var accesosAgrupados = registrosDelDia
                    .GroupBy(r => new
                    {
                        PersonaId = r.ResidenteId ?? r.InvitadoId ?? 0,
                        EsResidente = r.ResidenteId != null,
                        PlacasVehiculo = r.PlacasVehiculo ?? ""
                    })
                    .Select(g => new
                    {
                        Tipo = g.Key.EsResidente ? "Residente" : "Invitado",

                        Nombre = g.Key.EsResidente
                            ? g.FirstOrDefault(r => r.Residente != null)?.Residente?.Nombre + " " + g.FirstOrDefault(r => r.Residente != null)?.Residente?.Apellidos
                            : g.FirstOrDefault(r => r.Invitado != null)?.Invitado?.Nombre + " " + g.FirstOrDefault(r => r.Invitado != null)?.Invitado?.Apellidos,

                        Entrada = g.Where(r => r.TipoAcceso == TipoAcceso.Entrada)
                                  .OrderBy(r => r.FechaHora)
                                  .Select(r => r.FechaHora.ToString("HH:mm"))
                                  .FirstOrDefault() ?? "No registrado",

                        Salida = g.Where(r => r.TipoAcceso == TipoAcceso.Salida)
                                  .OrderByDescending(r => r.FechaHora)
                                  .Select(r => r.FechaHora.ToString("HH:mm"))
                                  .FirstOrDefault() ?? "No registrado",

                        TieneVehiculo = string.IsNullOrEmpty(g.Key.PlacasVehiculo) ? "No" : "Sí",

                        Placas = string.IsNullOrEmpty(g.Key.PlacasVehiculo) ? "" : g.Key.PlacasVehiculo
                    })
                    .ToList();

                dataGridView1.DataSource = accesosAgrupados;
            }
        }
    }
}
