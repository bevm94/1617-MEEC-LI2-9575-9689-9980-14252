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
        private Mat smallGrayFrame;
        private Mat smoothedGrayFrame;
        private Mat cannyFrame;
        private bool state_webcam = false;

        public form_main()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                capWebcam = new VideoCapture();
                capWebcam.ImageGrabbed += ProcessFrame;
                //conditions to flip camera horizontally or vertically
                //if (_capture != null) _capture.FlipHorizontal = !_capture.FlipHorizontal;
                //if (_capture != null) _capture.FlipVertical = !_capture.FlipVertical;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            frame = new Mat();
            grayFrame = new Mat();
            smallGrayFrame = new Mat();
            smoothedGrayFrame = new Mat();
            cannyFrame = new Mat();
        }

        private void ProcessFrame (object sender, EventArgs arg)
        {
            if (capWebcam != null && capWebcam.Ptr != IntPtr.Zero)
            {
                capWebcam.Retrieve(frame, 0);

                //CvInvoke.CvtColor(frame, grayFrame, ColorConversion.Bgr2Gray);

                //CvInvoke.PyrDown(grayFrame, smallGrayFrame);

                //CvInvoke.PyrUp(smallGrayFrame, smoothedGrayFrame);

                //CvInvoke.Canny(smoothedGrayFrame, cannyFrame, 100, 60);

                imageBox_frame.Image = frame;
                //grayscaleImageBox.Image = grayFrame;
                //smoothedGrayscaleImageBox.Image = smoothedGrayFrame;
                //cannyImageBox.Image = cannyFrame;
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

    }
}
