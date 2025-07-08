using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ControlDeAccesosDesktop
{
    public partial class Historial : Form
    {
        private Guardia guardia;
        public Historial(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscadorRI nuevaVentana = new BuscadorRI(guardia);
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialES nuevaVentana = new HistorialES(guardia);
            nuevaVentana.Show();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginGuardia nuevaVentana = new LoginGuardia();
            nuevaVentana.Show();
            this.Close();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }
    }
}
