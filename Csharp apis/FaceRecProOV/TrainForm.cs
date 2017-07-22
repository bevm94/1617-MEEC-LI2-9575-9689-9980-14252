using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;



namespace MultiFaceRec
{

    public partial class TrainForm : Form
    {
        int gpio_state_1, gpio_state_2, gpio_state_3, gpio_state_4;
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Image<Bgr, Byte> happyFrame;
        Image<Bgr, Byte> sadFrame;
        Image<Bgr, Byte> surprisedFrame;
        Image<Bgr, Byte> sleepyFrame;
        Image<Bgr, Byte> normalFrame;
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


        public TrainForm ()
        {
            InitializeComponent();
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string GPIOinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/GPIOPreferences.txt");
                string[] Labels = Labelsinfo.Split('%');
                string[] gpio = GPIOinfo.Split('%');
                //int[] single_gpio;
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

            }
        }

        void GetFrame (object sender, EventArgs e)
        {
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
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(200, 200, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

                //Eye Detector
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(eye, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                //NamePersons[t - 1] = name;
                //NamePersons.Add("");
                //Set the number of faces detected on the scene
                //label3.Text = facesDetected[0].Length.ToString();
            }
            t = 0;
            //Show the faces procesed and recognized
            imageBox_train.Image = currentFrame;
            //label4.Text = names;

        }

        private void bt_start_Click (object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(GetFrame);
            button1.Enabled = false;
        }

        private void bt_normal_frame_Click (object sender, EventArgs e)
        {
            if (txtbox_user.Text == "Please insert name")
            {
                MessageBox.Show("Please insert a valid user name!", "User name error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //Trained face counter
            ContTrain = ContTrain + 1;

            normalFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = normalFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txtbox_user.Text);

            //Show face added in gray scale
            imageBox_normal.Image = TrainedFace;

            //Write the number of trained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of trained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); //+ textBox1.Text 
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
            //MessageBox.Show(txtbox_user.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkbx_gpio1_CheckedChanged (object sender, EventArgs e)
        {
            if (chkbx_gpio1.Checked) gpio_state_1 = 1;
            else gpio_state_1 = 0;
        }

        private void chkbx_gpio2_CheckedChanged (object sender, EventArgs e)
        {
            if (chkbx_gpio2.Checked) gpio_state_2 = 1;
            else gpio_state_2 = 0;
        }

        private void chkbx_gpio4_CheckedChanged (object sender, EventArgs e)
        {
            if (chkbx_gpio4.Checked) gpio_state_4 = 1;
            else gpio_state_4 = 0;
        }

        private void bt_finish_train_Click (object sender, EventArgs e)
        {
            if (happyFrame == null || sadFrame == null || normalFrame == null || surprisedFrame == null || sleepyFrame == null)
            {
                DialogResult result;
                result = MessageBox.Show("Fullfill all of the training images!", "Not enough training images error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if ((String.IsNullOrEmpty(txtbox_user.Text)) || (txtbox_user.Text == "Please insert name"))
            {
                MessageBox.Show("Please insert a valid user name!", "User name error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if ((chkbx_gpio1.Checked && chkbx_gpio2.Checked && chkbx_gpio3.Checked && chkbx_gpio4.Checked)
           || !chkbx_gpio1.Checked && !chkbx_gpio2.Checked && !chkbx_gpio3.Checked && !chkbx_gpio4.Checked)
            {
                MessageBox.Show("Please do not select all or none of the GPIO states of the CAN module!", "GPIO Preferences error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/GPIOPreferences.txt", gpio_state_1.ToString() + gpio_state_2.ToString() + gpio_state_3.ToString() + gpio_state_4.ToString() + "%");
                    
                }
                MessageBox.Show("Training completed with sucess!", "Trained face completed" , MessageBoxButtons.OK);
                return;
            }


        }

        private void bt_sad_frame_Click (object sender, EventArgs e)
        {
            //Trained face counter
            ContTrain = ContTrain + 1;

            sadFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = sadFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }

            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txtbox_user.Text);

            //Show face added in gray scale
            imageBox_sad.Image = TrainedFace;

            //Write the number of trained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of trained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); //+ textBox1.Text 
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
        }

        private void imageBox_happy_Click (object sender, EventArgs e)
        {
            
        }

        private void bt_surprised_frame_Click (object sender, EventArgs e)
        {
            //Trained face counter
            ContTrain = ContTrain + 1;

            surprisedFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = normalFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txtbox_user.Text);

            //Show face added in gray scale
            imageBox_surprised.Image = TrainedFace;

            //Write the number of trained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of trained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); //+ textBox1.Text 
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
        }

        private void bt_sleepy_frame_Click (object sender, EventArgs e)
        {
            //Trained face counter
            ContTrain = ContTrain + 1;

            sleepyFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = normalFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txtbox_user.Text);

            //Show face added in gray scale
            imageBox_sleepy.Image = TrainedFace;

            //Write the number of trained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of trained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); //+ textBox1.Text 
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
        }

        private void bt_rmv_normal_Click (object sender, EventArgs e)
        {
            imageBox_normal.Image = null;

        }

        private void btt_rmv_happy_Click (object sender, EventArgs e)
        {
            imageBox_happy.Image = null;
        }

        private void bt_rmv_sad_Click (object sender, EventArgs e)
        {
            imageBox_sad.Image = null;
        }

        private void bt_rmv_surprised_Click (object sender, EventArgs e)
        {
            imageBox_surprised.Image = null;
        }

        private void bt_rmv_sleepy_Click (object sender, EventArgs e)
        {
            imageBox_sleepy.Image = null;
        }

        private void imageBox4_Click (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged (object sender, EventArgs e)
        {
            if (chkbx_gpio3.Checked) gpio_state_3 = 1;
            else gpio_state_3 = 0;
        }

        private void bt_happy_frame_Click (object sender, EventArgs e)
        {
            //Trained face counter
            ContTrain = ContTrain + 1;

            happyFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convert it to Grayscale
            gray = normalFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 2, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txtbox_user.Text);

            //Show face added in gray scale
            imageBox_happy.Image = TrainedFace;

            //Write the number of trained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

            //Write the labels of trained faces in a file text for further load
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp"); //+ textBox1.Text 
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter (object sender, EventArgs e)
        {

        }

        private void imageBox_train_Click (object sender, EventArgs e)
        {

        }
    }
}
