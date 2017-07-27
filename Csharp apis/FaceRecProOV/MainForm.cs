
//Multiple face detection and recognition in real time
//Using EmguCV cross platform .Net wrapper to the Intel OpenCV image processing library for C#.Net
//Writed by Sergio Andrés Guitérrez Rojas
//"Serg3ant" for the delveloper comunity
// Sergiogut1805@hotmail.com
//Regards from Bucaramanga-Colombia ;)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.IO.Ports;

namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        List<int> GpioPref = new List<int>();
        List<string> names_detected = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        int gpio_state_1, gpio_state_2, gpio_state_3, gpio_state_4;

        private String[] emotions = { "Happy", "Sad", "Normal", "Surprised", "Sleepy" };
        string serial_data;

        public FrmPrincipal ()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string GPIOinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/GPIOPreferences.txt");
                string[] Labels = Labelsinfo.Split('%');
                string[] gpio = GPIOinfo.Split('%');
                int[] single_gpio;
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Trained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void button1_Click (object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }

        void FrameGrabber (object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");

            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                //Eye Detector
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade( eye, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                        trainingImages.ToArray(),
                        labels.ToArray(),
                        2500,
                        ref termCrit);
                    name = recognizer.Recognize(result);

                    //Set the region of interest on the faces
                    foreach (MCvAvgComp ey in eyesDetected[0])
                    {
                        Rectangle eyeRect = ey.rect;
                        eyeRect.Offset(f.rect.X, f.rect.Y);
                        //Draw the rectangle for each eye detected
                        currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                    }
                }
                NamePersons[t - 1] = name;
                NamePersons.Add("");
                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();
            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
                names_detected.Add(NamePersons[nnn]);
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;

            //Write to Serial Port who was detected and their CAN GPIO preferences
            if (serialPort1.IsOpen)
            {
                serial_data = String.Format("{ User: {0} ; GPIO1: {1} ; GPIO2: {2} ; GPIO3: {3} ; GPIO4: {4}} \r\n", names_detected[0], gpio_state_1, gpio_state_2, gpio_state_3, gpio_state_4);
                serialPort1.Write(serial_data);
            }
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private void serialPortConfigurationToolStripMenuItem_Click (object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            SerialForm serialform = new SerialForm(serialPort1);

            // Show the settings form
            serialform.Show();
        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void imageBoxFrameGrabber_Click (object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewFaceToolStripMenuItem_Click (object sender, EventArgs e)
        {
            //Application.Idle -= new EventHandler(FrameGrabber);
            imageBoxFrameGrabber.Image = null;
            // Create a new instance of the Form2 class
            TrainForm trainform = new TrainForm();
            // Show the settings form
            trainform.Show();
        }

        private void databaseSettingsToolStripMenuItem_Click (object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click (object sender, EventArgs e)
        {

        }

        private void editDatabaseToolStripMenuItem_Click (object sender, EventArgs e)
        {
            imageBoxFrameGrabber.Image = null;
            // Create a new instance of the Form2 class
            EditDBForm editdbform = new EditDBForm();
            // Show the settings form
            editdbform.Show();
        }

        private void label4_Click (object sender, EventArgs e)
        {

        }

        private void webcamToolStripMenuItem_Click (object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }

        private void groupBox4_Enter (object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click (object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            AboutForm aboutform = new AboutForm();
            // Show the settings form
            aboutform.Show();
        }

        private void imageBox1_Click (object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click (object sender, EventArgs e)
        {

        }

        private void bt_serial_start_handler (object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                img_serial_state.Image = Properties.Resources.green_light;
                bt_start_serial.Text = "Close";
            } else if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                img_serial_state.Image = Properties.Resources.red_light;
                bt_start_serial.Text = "Start";
            }
                
        }
    }
}