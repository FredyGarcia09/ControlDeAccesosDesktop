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

namespace ControlDeAccesosDesktop
{
    public partial class RegistroResidentes : Form
    {
        private Residente residente;
        public RegistroResidentes(Residente residente)
        {
            InitializeComponent();
            this.residente = residente;
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
