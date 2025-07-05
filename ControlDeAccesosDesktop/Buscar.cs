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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial();
            nuevaVentana.Show();
            this.Hide();

        }

        private void btnresidentes_Click(object sender, EventArgs e)
        {
            BuscadorRI nuevaVentana = new BuscadorRI();
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnInvitados_Click(object sender, EventArgs e)
        {
            BuscadorRI nuevaVentana = new BuscadorRI();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
