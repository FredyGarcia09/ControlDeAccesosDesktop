using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.Drawing;
using Core.Models;

namespace ControlDeAccesosDesktop
{
    public partial class PanelAcceso : Form
    {

        private VideoCaptureDevice fuenteVideo;
        private string tipo;
        private Guardia guardia;

        public PanelAcceso(string tipo, Guardia guardia)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.guardia = guardia;
        }

        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Registro nuevaVentana = new Registro(guardia);
            nuevaVentana.Show();
            this.Close();
        }
    }
}
