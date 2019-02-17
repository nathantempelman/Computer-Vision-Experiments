using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.CvEnum;

namespace FuxingWIthCamerasNoWeb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //String win1 = "Test Window"; //The name of the window
            //CvInvoke.NamedWindow(win1); //Create the window using the specific name

            //Mat img = new Mat(200, 400, DepthType.Cv8U, 3); //Create a 3 channel image of 400x200
            //img.SetTo(new Bgr(255, 0, 0).MCvScalar); // set it to Blue color

            ////Draw "Hello, world." on the image using the specific font
            //CvInvoke.PutText(
            //   img,
            //   "Hello, world",
            //   new System.Drawing.Point(10, 80),
            //   FontFace.HersheyComplex,
            //   1.0,
            //   new Bgr(0, 255, 0).MCvScalar);


            //CvInvoke.Imshow(win1, img); //Show the image
            //CvInvoke.WaitKey(0);  //Wait for the key pressing event
            //CvInvoke.DestroyWindow(win1); //Destroy the window if key is pressed

            //CvInvoke.CalibrateCamera();
            //ImageViewer viewer = new ImageViewer(); //create an image viewer
            //Capture capture = new Capture(); //create a camera captue
            //Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            //{  //run this until application closed (close button click on image viewer)
            //    viewer.Image = capture.QueryFrame(); //draw the image obtained from camera
            //});
            //viewer.ShowDialog(); //show the image viewer

            //VideoCapture vc = new VideoCapture()

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VidCapper());
        }
    }
}
