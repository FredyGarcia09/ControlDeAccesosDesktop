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
        private Guardia guardia;
        public RegistroGuardias(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            using (var context = new ControlDbContext())
            {
                // Verifica si el usuario ya existe
                if (context.Guardias.Any(g => g.Usuario == usuario))
                {
                    MessageBox.Show("Este nombre de usuario ya está en uso. Elige otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el nuevo guardia
                var nuevoGuardia = new Guardia
                {
                    Nombre = nombre,
                    Usuario = usuario,
                    ContrasenaHash = contrasena
                };

                context.Guardias.Add(nuevoGuardia);
                context.SaveChanges();

                MessageBox.Show("Guardia registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtNombre.Clear();
                txtUsuario.Clear();
                txtContrasena.Clear();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }

        private void RegistroGuardias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
