using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

using DescGym.Comun;
using System.Drawing.Imaging;

namespace DescGym.uContoller
{
    public partial class uscWebCam : UserControl
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public String ImagenString { get; set; }
        public Bitmap ImagenBitmap { get; set; }

        private List<String> CamarasDetectadas = new List<string>();

        public uscWebCam()
        {
            InitializeComponent();
        }

        private void uscWebCam_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                CamarasDetectadas.Add(device.Name);
            }
            if (CamarasDetectadas.Count > 0)
            {                
                videoSource = new VideoCaptureDevice();
                btnTomar.Enabled = true;
            }
            else
            {
                
                btnTomar.Enabled = false;
            }
        }




        private void videoSource_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ImagenBitmap = (Bitmap)eventArgs.Frame.Clone();
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picUsuario.Image = ImagenBitmap;
        }
        public void FinalizarControles()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
            }
        }
        public void PonerFotografia(String pathImagen)
        {
            ImagenBitmap = new System.Drawing.Bitmap(pathImagen);
            ImagenString = ToolImagen.ToBase64String(ImagenBitmap, ImageFormat.Jpeg);
            picUsuario.Image = ImagenBitmap;
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();                
                this.picUsuario.Image = ImagenBitmap;
                picUsuario.Invalidate();
                btnTomar.Text = "Activar";
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_newFrame);
                videoSource.Start();
                btnTomar.Text = "Capturar";
            }
        }
    }
}
