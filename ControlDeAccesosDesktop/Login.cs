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
            txtContrase�a.PasswordChar = '*';

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string contrasena = txtContrase�a.Text;
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
                    MessageBox.Show("Usuario o contrase�a incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void LoginGuardia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "User Name")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                txtUser.Text = "User Name";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtContrase�a_Click(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "Password")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.Black;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrase�a.Text))
            {
                txtContrase�a.Text = "Password";
                txtContrase�a.ForeColor = Color.Gray;
            }
        }
    }
}
