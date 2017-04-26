namespace face_id
{
    partial class form_serial
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.comboBox_baud_rate = new System.Windows.Forms.ComboBox();
            this.combobox_data = new System.Windows.Forms.ComboBox();
            this.combobox_parity = new System.Windows.Forms.ComboBox();
            this.combobox_stop = new System.Windows.Forms.ComboBox();
            this.combobox_flowcontrol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stop :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(210, 27);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 24);
            this.comboBox_port.TabIndex = 7;
            // 
            // comboBox_baud_rate
            // 
            this.comboBox_baud_rate.FormattingEnabled = true;
            this.comboBox_baud_rate.Location = new System.Drawing.Point(210, 67);
            this.comboBox_baud_rate.Name = "comboBox_baud_rate";
            this.comboBox_baud_rate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baud_rate.TabIndex = 8;
            // 
            // combobox_data
            // 
            this.combobox_data.FormattingEnabled = true;
            this.combobox_data.Location = new System.Drawing.Point(210, 104);
            this.combobox_data.Name = "combobox_data";
            this.combobox_data.Size = new System.Drawing.Size(121, 24);
            this.combobox_data.TabIndex = 9;
            // 
            // combobox_parity
            // 
            this.combobox_parity.FormattingEnabled = true;
            this.combobox_parity.Location = new System.Drawing.Point(210, 145);
            this.combobox_parity.Name = "combobox_parity";
            this.combobox_parity.Size = new System.Drawing.Size(121, 24);
            this.combobox_parity.TabIndex = 10;
            // 
            // combobox_stop
            // 
            this.combobox_stop.FormattingEnabled = true;
            this.combobox_stop.Location = new System.Drawing.Point(210, 184);
            this.combobox_stop.Name = "combobox_stop";
            this.combobox_stop.Size = new System.Drawing.Size(121, 24);
            this.combobox_stop.TabIndex = 11;
            this.combobox_stop.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // combobox_flowcontrol
            // 
            this.combobox_flowcontrol.FormattingEnabled = true;
            this.combobox_flowcontrol.Location = new System.Drawing.Point(210, 221);
            this.combobox_flowcontrol.Name = "combobox_flowcontrol";
            this.combobox_flowcontrol.Size = new System.Drawing.Size(121, 24);
            this.combobox_flowcontrol.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flow Control :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(420, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Default";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // form_serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 288);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.combobox_flowcontrol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobox_stop);
            this.Controls.Add(this.combobox_parity);
            this.Controls.Add(this.combobox_data);
            this.Controls.Add(this.comboBox_baud_rate);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form_serial";
            this.Text = "serial_config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.ComboBox comboBox_baud_rate;
        private System.Windows.Forms.ComboBox combobox_data;
        private System.Windows.Forms.ComboBox combobox_parity;
        private System.Windows.Forms.ComboBox combobox_stop;
        private System.Windows.Forms.ComboBox combobox_flowcontrol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}