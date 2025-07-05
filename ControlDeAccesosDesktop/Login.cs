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

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Historial nuevaVentana = new Historial(); 
            nuevaVentana.Show();              
            this.Hide();                      

        }
    }
}
