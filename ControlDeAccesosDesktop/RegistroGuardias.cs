using Core.Models;
using DataAccess.Data;
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
    public partial class RegistroGuardias : Form
    {
        public RegistroGuardias()
        {
            InitializeComponent();
            CargarGuardias();
        }

        private int guardiaSeleccionadoId = 0;


        private void CargarGuardias()
        {
            using (var db = new ControlDbContext())
            {
                dgvGuardias.DataSource = db.Guardias
                    .Select(g => new { g.Id, g.Nombre, g.Usuario })
                    .ToList();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            guardiaSeleccionadoId = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            using (var db = new ControlDbContext())
            {
                // Validar que no exista usuario duplicado
                if (db.Guardias.Any(g => g.Usuario == txtUsuario.Text.Trim()))
                {
                    MessageBox.Show("Ya existe un guardia con ese nombre de usuario.");
                    return;
                }

                var guardia = new Guardia
                {
                    Nombre = txtNombre.Text.Trim(),
                    Usuario = txtUsuario.Text.Trim(),
                    ContrasenaHash = txtContrasena.Text // ideal: aplicar hash
                };

                db.Guardias.Add(guardia);
                db.SaveChanges();
            }

            CargarGuardias();
            LimpiarCampos();
            MessageBox.Show("Guardia agregado correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (guardiaSeleccionadoId == 0)
            {
                MessageBox.Show("Selecciona un guardia de la tabla para editar.");
                return;
            }

            using (var db = new AppDbContext())
            {
                var guardia = db.Guardias.Find(guardiaSeleccionadoId);
                if (guardia != null)
                {
                    guardia.Nombre = txtNombre.Text.Trim();
                    guardia.Usuario = txtUsuario.Text.Trim();
                    guardia.ContrasenaHash = txtContrasena.Text;

                    db.SaveChanges();
                }
            }

            CargarGuardias();
            LimpiarCampos();
            MessageBox.Show("Guardia actualizado.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (guardiaSeleccionadoId == 0)
            {
                MessageBox.Show("Selecciona un guardia para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este guardia?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (var db = new AppDbContext())
            {
                var guardia = db.Guardias.Find(guardiaSeleccionadoId);
                if (guardia != null)
                {
                    db.Guardias.Remove(guardia);
                    db.SaveChanges();
                }
            }

            CargarGuardias();
            LimpiarCampos();
            MessageBox.Show("Guardia eliminado.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvGuardias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGuardias.CurrentRow != null)
            {
                var fila = dgvGuardias.Rows[e.RowIndex];
                guardiaSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();

                using (var db = new AppDbContext())
                {
                    var guardia = db.Guardias.Find(guardiaSeleccionadoId);
                    if (guardia != null)
                        txtContrasena.Text = guardia.ContrasenaHash;
                }
            }
        }
    }
}
