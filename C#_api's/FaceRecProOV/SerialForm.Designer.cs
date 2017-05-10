namespace MultiFaceRec
{
    partial class SerialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_brate = new System.Windows.Forms.ComboBox();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.comboBox_parity = new System.Windows.Forms.ComboBox();
            this.comboBox_stop = new System.Windows.Forms.ComboBox();
            this.comboBox_f_control = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_default = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flow Control :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(183, 37);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 24);
            this.comboBox_port.TabIndex = 6;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_brate
            // 
            this.comboBox_brate.FormattingEnabled = true;
            this.comboBox_brate.Location = new System.Drawing.Point(183, 78);
            this.comboBox_brate.Name = "comboBox_brate";
            this.comboBox_brate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_brate.TabIndex = 7;
            this.comboBox_brate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(183, 121);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(121, 24);
            this.comboBox_data.TabIndex = 8;
            // 
            // comboBox_parity
            // 
            this.comboBox_parity.FormattingEnabled = true;
            this.comboBox_parity.Location = new System.Drawing.Point(183, 164);
            this.comboBox_parity.Name = "comboBox_parity";
            this.comboBox_parity.Size = new System.Drawing.Size(121, 24);
            this.comboBox_parity.TabIndex = 9;
            this.comboBox_parity.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox_stop
            // 
            this.comboBox_stop.FormattingEnabled = true;
            this.comboBox_stop.Location = new System.Drawing.Point(183, 207);
            this.comboBox_stop.Name = "comboBox_stop";
            this.comboBox_stop.Size = new System.Drawing.Size(121, 24);
            this.comboBox_stop.TabIndex = 10;
            // 
            // comboBox_f_control
            // 
            this.comboBox_f_control.FormattingEnabled = true;
            this.comboBox_f_control.Location = new System.Drawing.Point(183, 250);
            this.comboBox_f_control.Name = "comboBox_f_control";
            this.comboBox_f_control.Size = new System.Drawing.Size(121, 24);
            this.comboBox_f_control.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(424, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_default
            // 
            this.bt_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_default.Location = new System.Drawing.Point(424, 203);
            this.bt_default.Name = "bt_default";
            this.bt_default.Size = new System.Drawing.Size(110, 48);
            this.bt_default.TabIndex = 14;
            this.bt_default.Text = "Default";
            this.bt_default.UseVisualStyleBackColor = true;
            this.bt_default.Click += new System.EventHandler(this.button3_Click);
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 331);
            this.Controls.Add(this.bt_default);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_f_control);
            this.Controls.Add(this.comboBox_stop);
            this.Controls.Add(this.comboBox_parity);
            this.Controls.Add(this.comboBox_data);
            this.Controls.Add(this.comboBox_brate);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SerialForm";
            this.Text = "SerialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_brate;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_parity;
        private System.Windows.Forms.ComboBox comboBox_stop;
        private System.Windows.Forms.ComboBox comboBox_f_control;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_default;
    }
}