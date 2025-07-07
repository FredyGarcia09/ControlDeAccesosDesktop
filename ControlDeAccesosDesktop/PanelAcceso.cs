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

namespace ControlDeAccesosDesktop
{
    public partial class PanelAcceso : Form
    {
        private FilterInfoCollection dispositivosVideo;
        private VideoCaptureDevice fuenteVideo;

        public PanelAcceso()
        {
            InitializeComponent();
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosVideo.Count > 0)
            {
                fuenteVideo = new VideoCaptureDevice(dispositivosVideo[0].MonikerString);
                fuenteVideo.NewFrame += FuenteVideo_NewFrame;
            }
            else
            {
                MessageBox.Show("No se detectó una cámara.");
            }
        }

        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            if (fuenteVideo != null && !fuenteVideo.IsRunning)
            {
                pbCamara.SizeMode = PictureBoxSizeMode.StretchImage;
                fuenteVideo.Start();
                timerQR.Start();  
            }
        }

        private void FuenteVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pbCamara.Image = frame;
        }

        private void timerQR_Tick(object sender, EventArgs e)
        {
            if (pbCamara.Image != null)
            {
                Bitmap bitmap = new Bitmap(pbCamara.Image);
                BarcodeReader lector = new BarcodeReader();
                var resultado = lector.Decode(bitmap);
                if (resultado != null)
                {
                    txtCodigoQR.Text = resultado.Text;
                    timerQR.Stop();
                    fuenteVideo.SignalToStop();

                    // Simula el botón buscar QR
                    btnBuscar.PerformClick();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (fuenteVideo != null && fuenteVideo.IsRunning)
            {
                fuenteVideo.SignalToStop();
            }
            base.OnFormClosing(e);
        }
    }
}
