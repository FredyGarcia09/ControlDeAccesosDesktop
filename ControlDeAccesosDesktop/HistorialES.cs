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
    }
}
