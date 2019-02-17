using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace FuxingWIthCamerasNoWeb
{
    public partial class VidCapper : Form
    {
        VideoCapture _capture;
        private Mat _frame;


        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame, 0);
                Image<Gray, byte> grayframe = _frame.ToImage<Gray, byte>();

                //IImage image1 = new UMat()

                long detectionTime;
                List<Rectangle> faces = new List<Rectangle>();
                List<Rectangle> eyes = new List<Rectangle>();

                DetectFace.Detect(
                  _frame, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
                  faces, eyes,
                  out detectionTime);

                foreach (Rectangle face in faces)
                    CvInvoke.Rectangle(_frame, face, new Bgr(Color.Red).MCvScalar, 2);
                foreach (Rectangle eye in eyes)
                    CvInvoke.Rectangle(_frame, eye, new Bgr(Color.Blue).MCvScalar, 2);

                //display the image 
                //using (InputArray iaImage = image.GetInputArray())
                //    ImageViewer.Show(image, String.Format(
                //       "Completed face and eye detection using {0} in {1} milliseconds",
                //       (iaImage.Kind == InputArray.Type.CudaGpuMat && CudaInvoke.HasCuda) ? "CUDA" :
                //       (iaImage.IsUMat && CvInvoke.UseOpenCL) ? "OpenCL"
                //       : "CPU",
                //       detectionTime));


              //  pictureBox1.Image = _frame.Bitmap;

                pictureBox1.Image = _frame.Bitmap;
            }
        }

        public VidCapper()
        {
            InitializeComponent();

            _capture = new VideoCapture(0);


            _capture.ImageGrabbed += ProcessFrame;
            _frame = new Mat();
            if (_capture != null)
            {
                try
                {
                    _capture.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
