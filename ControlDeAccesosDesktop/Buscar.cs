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
    public partial class Buscar : Form
    {
        public string TipoPersona { get; set; } // "Residente" o "Invitado"
        private Guardia guardia;
        public Buscar(Guardia guardia)
        {
            InitializeComponent();
            this.guardia = guardia;
        }

        private void btnRegresa_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(guardia);
            nuevaVentana.Show();
            this.Hide();

        }

        private void btnresidentes_Click(object sender, EventArgs e)
        {
            BuscadorRI ventanaHistorial = new BuscadorRI();
            ventanaHistorial.TipoPersona = "Residente"; // que buscar
            ventanaHistorial.Show();                    
            this.Hide();
        }

        private void btnInvitados_Click(object sender, EventArgs e)
        {
            BuscadorRI ventanaHistorial = new BuscadorRI();
            ventanaHistorial.TipoPersona = "Invitado"; // que buscar
            ventanaHistorial.Show();
            this.Hide();
        }
    }
}
