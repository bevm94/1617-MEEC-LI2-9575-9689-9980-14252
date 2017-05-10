using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace MultiFaceRec
{
    public partial class SerialForm : Form 
    {
        SerialPort myPort;

        private String[] list_baudrate = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "57600", "115200" };
        private String[] list_data_bits = { "7", "8" };
        private String[] list_parity = { "None", "Odd", "Even", "Mark", "Space" };
        private String[] list_stop_bits = { "None", "1 bit", "2 bits", "1.5 bits" };
        private String[] list_flow_control = { "None", "Xon / Xoff", "RequestToSend", "RequestToSend Xon / Xoff" };

        public void fill_combo_boxes()
        {
            comboBox_brate.DataSource = list_baudrate;
            comboBox_data.DataSource = list_data_bits;
            comboBox_parity.DataSource = list_parity;
            comboBox_stop.DataSource = list_stop_bits;
            comboBox_f_control.DataSource = list_flow_control;
        }

        public SerialForm (SerialPort port)
        {

            InitializeComponent();
            myPort = port;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String.Format("\\.\%s",);
            myPort.PortName = Convert.ToString(comboBox_port.Text);
            myPort.BaudRate = Convert.ToInt32(comboBox_brate.Text);
            myPort.Parity = (Parity)(Parity)Enum.Parse(typeof(Parity), comboBox_parity.Text);
            myPort.StopBits = (StopBits)(StopBits)Enum.Parse(typeof(StopBits), comboBox_stop.Text);
            myPort.DataBits = Convert.ToInt16(comboBox_data.Text);
            myPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_f_control.Text);

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox_brate.Text = "9600";
            comboBox_data.Text= "8";
            comboBox_parity.Text = "None" ;
            comboBox_f_control.Text = "None";
            comboBox_stop.Text = "One";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SerialForm_Load (object sender, EventArgs e)
        {
            fill_combo_boxes();
            var ports = SerialPort.GetPortNames();
            comboBox_port.DataSource = ports;
        }

        private void button1_Click_1 (object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            comboBox_port.DataSource = ports;
        }
    }
}
