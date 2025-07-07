using static System.Runtime.InteropServices.JavaScript.JSType;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace ControlDeAccesosDesktop
{
    public partial class LoginGuardia : Form
    {
        public LoginGuardia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '*';

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string contrasena = txtContraseña.Text;
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, completa ambos campos.");
                return;
            }


            using (var context = new ControlDbContext())
            {
                var guardia = context.Guardias
                    .FirstOrDefault(g => g.Usuario == usuario && g.ContrasenaHash == contrasena);

                if (guardia != null)
                {
                    // Login exitoso
                    MessageBox.Show("Bienvenido " + guardia.Nombre, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir siguiente ventana
                    var menu = new Historial(guardia);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
