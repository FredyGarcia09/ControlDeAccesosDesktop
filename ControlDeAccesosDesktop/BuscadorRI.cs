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
    public partial class BuscadorRI : Form
    {
        public BuscadorRI()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            gbReIn.Visible = true;
        }

        private void BuscadorRI_Load(object sender, EventArgs e)
        {
            gbReIn.Visible = false;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Buscar nuevaVentana = new Buscar();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
