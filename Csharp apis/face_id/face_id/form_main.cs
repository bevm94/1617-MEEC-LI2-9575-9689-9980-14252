using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;                  //
using Emgu.CV.CvEnum;           // usual Emgu Cv imports
using Emgu.CV.Structure;        //
using Emgu.CV.UI;               //

namespace face_id
{
    public partial class form_main : Form
    {
        private VideoCapture capWebcam;
        private Mat frame;
        private Mat grayFrame;
        private Image<Bgr, Byte> currentimage;
        private Image<Bgr, Byte> grayimage;
        private bool state_webcam = false;
        private CascadeClassifier face = new CascadeClassifier(Application.StartupPath + "\\haarcascade_frontalface_default.xml");
        private CascadeClassifier face_best = new CascadeClassifier(Application.StartupPath + "\\haarcascade_frontalface_alt_tree.xml");
        private CascadeClassifier eyes = new CascadeClassifier(Application.StartupPath + "\\haarcascade_eye.xml");
        public form_main()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                capWebcam = new VideoCapture();
                capWebcam.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            frame = new Mat();
            grayFrame = new Mat();
        }

        private void ProcessFrame (object sender, EventArgs arg)
        {
            if (capWebcam != null && capWebcam.Ptr != IntPtr.Zero)
            {
                capWebcam.Retrieve(frame, 0);
                //currentimage = capWebcam.QueryFrame().ToImage<Bgr, Byte>();
                //frame = capWebcam.QueryFrame();

                CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);
                //grayimage = grayFrame.ToImage<Bgr, Byte>();
                Rectangle[] rect_face = face_best.DetectMultiScale(grayFrame, 1.1, 10, Size.Empty); //the actual face detection happens here

                foreach (var face in rect_face)
                {
                    currentimage = frame.ToImage<Bgr, Byte>();
                    frame.
                    currentimage.Draw(face, new Bgr(Color.BurlyWood), 3); //the detected face(s) is highlighted here using a box that is drawn around it/them
                }
                //frame = currentimage.Mat;
                imageBox_frame.Image = frame;
                //imageBox_gray.Image = grayFrame;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //Start or pause the webcam on the menu tool strip
        private void webcamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (capWebcam != null)
            {
                if (state_webcam == false)
                {
                    webcamToolStripMenuItem.Checked = false;
                    capWebcam.Pause();
                } else
                {
                    capWebcam.Start();
                    webcamToolStripMenuItem.Checked = true;
                }
                state_webcam =! state_webcam;

            }
        }
        //function to load an image
        private void bt_openfile_Click(object sender, EventArgs e)
        {
            DialogResult drChosenFile;

            drChosenFile = open_file_dialog.ShowDialog();

            if (drChosenFile != DialogResult.OK || open_file_dialog.FileName == "")
            {
                return;
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {

        }
        //function to dispose all the data from capture device
        private void ReleaseData ()
        {
            if (capWebcam != null)
                capWebcam.Dispose();
        }

        private void imageBox1_Click (object sender, EventArgs e)
        {

        }
    }
}
