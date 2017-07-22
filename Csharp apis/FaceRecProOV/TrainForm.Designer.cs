namespace MultiFaceRec
{
    partial class TrainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainForm));
            this.imageBox_train = new Emgu.CV.UI.ImageBox();
            this.imageBox_happy = new Emgu.CV.UI.ImageBox();
            this.imageBox_sad = new Emgu.CV.UI.ImageBox();
            this.imageBox_normal = new Emgu.CV.UI.ImageBox();
            this.imageBox_sleepy = new Emgu.CV.UI.ImageBox();
            this.imageBox_surprised = new Emgu.CV.UI.ImageBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbx_gpio1 = new System.Windows.Forms.CheckBox();
            this.chkbx_gpio2 = new System.Windows.Forms.CheckBox();
            this.chkbx_gpio3 = new System.Windows.Forms.CheckBox();
            this.chkbx_gpio4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_happy_frame = new System.Windows.Forms.Button();
            this.bt_sad_frame = new System.Windows.Forms.Button();
            this.bt_normal_frame = new System.Windows.Forms.Button();
            this.bt_surprised_frame = new System.Windows.Forms.Button();
            this.bt_sleepy_frame = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_rmv_sleepy = new System.Windows.Forms.Button();
            this.bt_rmv_surprised = new System.Windows.Forms.Button();
            this.bt_rmv_sad = new System.Windows.Forms.Button();
            this.btt_rmv_happy = new System.Windows.Forms.Button();
            this.bt_rmv_normal = new System.Windows.Forms.Button();
            this.bt_finish_train = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_train)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_sleepy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_surprised)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox_train
            // 
            this.imageBox_train.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_train.Location = new System.Drawing.Point(141, 59);
            this.imageBox_train.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_train.Name = "imageBox_train";
            this.imageBox_train.Size = new System.Drawing.Size(554, 379);
            this.imageBox_train.TabIndex = 5;
            this.imageBox_train.TabStop = false;
            this.imageBox_train.Click += new System.EventHandler(this.imageBox_train_Click);
            // 
            // imageBox_happy
            // 
            this.imageBox_happy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_happy.Location = new System.Drawing.Point(218, 40);
            this.imageBox_happy.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_happy.Name = "imageBox_happy";
            this.imageBox_happy.Size = new System.Drawing.Size(142, 122);
            this.imageBox_happy.TabIndex = 6;
            this.imageBox_happy.TabStop = false;
            this.imageBox_happy.Click += new System.EventHandler(this.imageBox_happy_Click);
            // 
            // imageBox_sad
            // 
            this.imageBox_sad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_sad.Location = new System.Drawing.Point(402, 40);
            this.imageBox_sad.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_sad.Name = "imageBox_sad";
            this.imageBox_sad.Size = new System.Drawing.Size(142, 122);
            this.imageBox_sad.TabIndex = 7;
            this.imageBox_sad.TabStop = false;
            // 
            // imageBox_normal
            // 
            this.imageBox_normal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_normal.Location = new System.Drawing.Point(25, 40);
            this.imageBox_normal.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_normal.Name = "imageBox_normal";
            this.imageBox_normal.Size = new System.Drawing.Size(142, 122);
            this.imageBox_normal.TabIndex = 8;
            this.imageBox_normal.TabStop = false;
            // 
            // imageBox_sleepy
            // 
            this.imageBox_sleepy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_sleepy.Location = new System.Drawing.Point(770, 40);
            this.imageBox_sleepy.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_sleepy.Name = "imageBox_sleepy";
            this.imageBox_sleepy.Size = new System.Drawing.Size(142, 122);
            this.imageBox_sleepy.TabIndex = 9;
            this.imageBox_sleepy.TabStop = false;
            this.imageBox_sleepy.Click += new System.EventHandler(this.imageBox4_Click);
            // 
            // imageBox_surprised
            // 
            this.imageBox_surprised.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox_surprised.Location = new System.Drawing.Point(586, 40);
            this.imageBox_surprised.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox_surprised.Name = "imageBox_surprised";
            this.imageBox_surprised.Size = new System.Drawing.Size(142, 122);
            this.imageBox_surprised.TabIndex = 10;
            this.imageBox_surprised.TabStop = false;
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(800, 68);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(136, 22);
            this.txtbox_user.TabIndex = 11;
            this.txtbox_user.Text = "Please insert name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkbx_gpio1
            // 
            this.chkbx_gpio1.AutoSize = true;
            this.chkbx_gpio1.Location = new System.Drawing.Point(12, 30);
            this.chkbx_gpio1.Name = "chkbx_gpio1";
            this.chkbx_gpio1.Size = new System.Drawing.Size(76, 21);
            this.chkbx_gpio1.TabIndex = 13;
            this.chkbx_gpio1.Text = "GPIO 1";
            this.chkbx_gpio1.UseVisualStyleBackColor = true;
            this.chkbx_gpio1.CheckedChanged += new System.EventHandler(this.chkbx_gpio1_CheckedChanged);
            // 
            // chkbx_gpio2
            // 
            this.chkbx_gpio2.AutoSize = true;
            this.chkbx_gpio2.Location = new System.Drawing.Point(12, 57);
            this.chkbx_gpio2.Name = "chkbx_gpio2";
            this.chkbx_gpio2.Size = new System.Drawing.Size(76, 21);
            this.chkbx_gpio2.TabIndex = 14;
            this.chkbx_gpio2.Text = "GPIO 2";
            this.chkbx_gpio2.UseVisualStyleBackColor = true;
            this.chkbx_gpio2.CheckedChanged += new System.EventHandler(this.chkbx_gpio2_CheckedChanged);
            // 
            // chkbx_gpio3
            // 
            this.chkbx_gpio3.AutoSize = true;
            this.chkbx_gpio3.Location = new System.Drawing.Point(12, 84);
            this.chkbx_gpio3.Name = "chkbx_gpio3";
            this.chkbx_gpio3.Size = new System.Drawing.Size(76, 21);
            this.chkbx_gpio3.TabIndex = 15;
            this.chkbx_gpio3.Text = "GPIO 3";
            this.chkbx_gpio3.UseVisualStyleBackColor = true;
            this.chkbx_gpio3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkbx_gpio4
            // 
            this.chkbx_gpio4.AutoSize = true;
            this.chkbx_gpio4.Location = new System.Drawing.Point(12, 111);
            this.chkbx_gpio4.Name = "chkbx_gpio4";
            this.chkbx_gpio4.Size = new System.Drawing.Size(76, 21);
            this.chkbx_gpio4.TabIndex = 16;
            this.chkbx_gpio4.Text = "GPIO 4";
            this.chkbx_gpio4.UseVisualStyleBackColor = true;
            this.chkbx_gpio4.CheckedChanged += new System.EventHandler(this.chkbx_gpio4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hScrollBar1);
            this.groupBox1.Controls.Add(this.chkbx_gpio4);
            this.groupBox1.Controls.Add(this.chkbx_gpio1);
            this.groupBox1.Controls.Add(this.chkbx_gpio3);
            this.groupBox1.Controls.Add(this.chkbx_gpio2);
            this.groupBox1.Location = new System.Drawing.Point(702, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 199);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPIO Preferences";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "PWM";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 151);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(159, 28);
            this.hScrollBar1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_happy_frame
            // 
            this.bt_happy_frame.Location = new System.Drawing.Point(218, 166);
            this.bt_happy_frame.Name = "bt_happy_frame";
            this.bt_happy_frame.Size = new System.Drawing.Size(98, 45);
            this.bt_happy_frame.TabIndex = 24;
            this.bt_happy_frame.Text = "Happy Face";
            this.bt_happy_frame.UseVisualStyleBackColor = true;
            this.bt_happy_frame.Click += new System.EventHandler(this.bt_happy_frame_Click);
            // 
            // bt_sad_frame
            // 
            this.bt_sad_frame.Location = new System.Drawing.Point(402, 167);
            this.bt_sad_frame.Name = "bt_sad_frame";
            this.bt_sad_frame.Size = new System.Drawing.Size(98, 45);
            this.bt_sad_frame.TabIndex = 25;
            this.bt_sad_frame.Text = "Sad Face";
            this.bt_sad_frame.UseVisualStyleBackColor = true;
            this.bt_sad_frame.Click += new System.EventHandler(this.bt_sad_frame_Click);
            // 
            // bt_normal_frame
            // 
            this.bt_normal_frame.Location = new System.Drawing.Point(25, 166);
            this.bt_normal_frame.Name = "bt_normal_frame";
            this.bt_normal_frame.Size = new System.Drawing.Size(98, 45);
            this.bt_normal_frame.TabIndex = 26;
            this.bt_normal_frame.Text = "Normal Face";
            this.bt_normal_frame.UseVisualStyleBackColor = true;
            this.bt_normal_frame.Click += new System.EventHandler(this.bt_normal_frame_Click);
            // 
            // bt_surprised_frame
            // 
            this.bt_surprised_frame.Location = new System.Drawing.Point(586, 166);
            this.bt_surprised_frame.Name = "bt_surprised_frame";
            this.bt_surprised_frame.Size = new System.Drawing.Size(98, 45);
            this.bt_surprised_frame.TabIndex = 27;
            this.bt_surprised_frame.Text = "Surprised Face";
            this.bt_surprised_frame.UseVisualStyleBackColor = true;
            this.bt_surprised_frame.Click += new System.EventHandler(this.bt_surprised_frame_Click);
            // 
            // bt_sleepy_frame
            // 
            this.bt_sleepy_frame.Location = new System.Drawing.Point(770, 166);
            this.bt_sleepy_frame.Name = "bt_sleepy_frame";
            this.bt_sleepy_frame.Size = new System.Drawing.Size(98, 45);
            this.bt_sleepy_frame.TabIndex = 28;
            this.bt_sleepy_frame.Text = "Sleepy Face";
            this.bt_sleepy_frame.UseVisualStyleBackColor = true;
            this.bt_sleepy_frame.Click += new System.EventHandler(this.bt_sleepy_frame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_rmv_sleepy);
            this.groupBox2.Controls.Add(this.bt_rmv_surprised);
            this.groupBox2.Controls.Add(this.bt_rmv_sad);
            this.groupBox2.Controls.Add(this.btt_rmv_happy);
            this.groupBox2.Controls.Add(this.bt_rmv_normal);
            this.groupBox2.Controls.Add(this.imageBox_normal);
            this.groupBox2.Controls.Add(this.bt_sleepy_frame);
            this.groupBox2.Controls.Add(this.imageBox_happy);
            this.groupBox2.Controls.Add(this.bt_surprised_frame);
            this.groupBox2.Controls.Add(this.imageBox_sad);
            this.groupBox2.Controls.Add(this.bt_normal_frame);
            this.groupBox2.Controls.Add(this.imageBox_sleepy);
            this.groupBox2.Controls.Add(this.bt_sad_frame);
            this.groupBox2.Controls.Add(this.imageBox_surprised);
            this.groupBox2.Controls.Add(this.bt_happy_frame);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(44, 445);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(943, 226);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trained faces";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bt_rmv_sleepy
            // 
            this.bt_rmv_sleepy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_rmv_sleepy.BackgroundImage")));
            this.bt_rmv_sleepy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_rmv_sleepy.Location = new System.Drawing.Point(874, 169);
            this.bt_rmv_sleepy.Name = "bt_rmv_sleepy";
            this.bt_rmv_sleepy.Size = new System.Drawing.Size(38, 40);
            this.bt_rmv_sleepy.TabIndex = 33;
            this.bt_rmv_sleepy.UseVisualStyleBackColor = true;
            this.bt_rmv_sleepy.Click += new System.EventHandler(this.bt_rmv_sleepy_Click);
            // 
            // bt_rmv_surprised
            // 
            this.bt_rmv_surprised.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_rmv_surprised.BackgroundImage")));
            this.bt_rmv_surprised.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_rmv_surprised.Location = new System.Drawing.Point(690, 169);
            this.bt_rmv_surprised.Name = "bt_rmv_surprised";
            this.bt_rmv_surprised.Size = new System.Drawing.Size(38, 40);
            this.bt_rmv_surprised.TabIndex = 32;
            this.bt_rmv_surprised.UseVisualStyleBackColor = true;
            this.bt_rmv_surprised.Click += new System.EventHandler(this.bt_rmv_surprised_Click);
            // 
            // bt_rmv_sad
            // 
            this.bt_rmv_sad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_rmv_sad.BackgroundImage")));
            this.bt_rmv_sad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_rmv_sad.Location = new System.Drawing.Point(506, 171);
            this.bt_rmv_sad.Name = "bt_rmv_sad";
            this.bt_rmv_sad.Size = new System.Drawing.Size(38, 40);
            this.bt_rmv_sad.TabIndex = 31;
            this.bt_rmv_sad.UseVisualStyleBackColor = true;
            this.bt_rmv_sad.Click += new System.EventHandler(this.bt_rmv_sad_Click);
            // 
            // btt_rmv_happy
            // 
            this.btt_rmv_happy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_rmv_happy.BackgroundImage")));
            this.btt_rmv_happy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btt_rmv_happy.Location = new System.Drawing.Point(322, 171);
            this.btt_rmv_happy.Name = "btt_rmv_happy";
            this.btt_rmv_happy.Size = new System.Drawing.Size(38, 40);
            this.btt_rmv_happy.TabIndex = 30;
            this.btt_rmv_happy.UseVisualStyleBackColor = true;
            this.btt_rmv_happy.Click += new System.EventHandler(this.btt_rmv_happy_Click);
            // 
            // bt_rmv_normal
            // 
            this.bt_rmv_normal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_rmv_normal.BackgroundImage")));
            this.bt_rmv_normal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_rmv_normal.Location = new System.Drawing.Point(129, 169);
            this.bt_rmv_normal.Name = "bt_rmv_normal";
            this.bt_rmv_normal.Size = new System.Drawing.Size(38, 40);
            this.bt_rmv_normal.TabIndex = 29;
            this.bt_rmv_normal.UseVisualStyleBackColor = true;
            this.bt_rmv_normal.Click += new System.EventHandler(this.bt_rmv_normal_Click);
            // 
            // bt_finish_train
            // 
            this.bt_finish_train.Location = new System.Drawing.Point(714, 358);
            this.bt_finish_train.Name = "bt_finish_train";
            this.bt_finish_train.Size = new System.Drawing.Size(98, 45);
            this.bt_finish_train.TabIndex = 30;
            this.bt_finish_train.Text = "Training done!";
            this.bt_finish_train.UseVisualStyleBackColor = true;
            this.bt_finish_train.Click += new System.EventHandler(this.bt_finish_train_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(36, 182);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(98, 45);
            this.bt_start.TabIndex = 31;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 696);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_finish_train);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_user);
            this.Controls.Add(this.imageBox_train);
            this.Name = "TrainForm";
            this.Text = "TrainForm";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_train)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_sleepy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox_surprised)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox_train;
        private Emgu.CV.UI.ImageBox imageBox_happy;
        private Emgu.CV.UI.ImageBox imageBox_sad;
        private Emgu.CV.UI.ImageBox imageBox_normal;
        private Emgu.CV.UI.ImageBox imageBox_sleepy;
        private Emgu.CV.UI.ImageBox imageBox_surprised;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbx_gpio1;
        private System.Windows.Forms.CheckBox chkbx_gpio2;
        private System.Windows.Forms.CheckBox chkbx_gpio3;
        private System.Windows.Forms.CheckBox chkbx_gpio4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_happy_frame;
        private System.Windows.Forms.Button bt_sad_frame;
        private System.Windows.Forms.Button bt_normal_frame;
        private System.Windows.Forms.Button bt_surprised_frame;
        private System.Windows.Forms.Button bt_sleepy_frame;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_finish_train;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_rmv_sleepy;
        private System.Windows.Forms.Button bt_rmv_surprised;
        private System.Windows.Forms.Button bt_rmv_sad;
        private System.Windows.Forms.Button btt_rmv_happy;
        private System.Windows.Forms.Button bt_rmv_normal;
        private System.Windows.Forms.TextBox txtbox_user;
    }
}