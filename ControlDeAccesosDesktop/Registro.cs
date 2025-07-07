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
    public partial class Registro : Form
    {
        private Guardia guardia;
        public Registro(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(guardia);
            nuevaVentana.Show();
            this.Hide();

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            PanelAcceso nuevaVentana = new PanelAcceso("Entrada", guardia);
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            PanelAcceso nuevaVentana = new PanelAcceso("Salida", guardia);
            nuevaVentana.Show();
            this.Hide();
        }

        private void btnGuardia_Click(object sender, EventArgs e)
        {
            RegistroGuardias nuevaVentana = new RegistroGuardias();
            nuevaVentana.Show();
            this.Hide();
        }
    }
}
