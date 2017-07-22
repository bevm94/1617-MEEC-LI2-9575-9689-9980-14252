using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace face_id
{
    public partial class form_serial : Form
    {
        private String[] list_baudrate = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "57600", "115200" };
        private String[] list_data_bits = { "7 bit","8 bit" };
        private String[] list_parity = { "None", "Odd", "Even", "Mark", "Space" };
        private String[] list_stop_bits = { "1 bit", "1.5 bits", "2 bits" };
        private String[] list_flow_control = { "None", "Xon / Xoff", "Hardware" };

        public void fill_combo_boxes()
        {
            comboBox_baud_rate.DataSource = list_baudrate;
            comboBox_baud_rate.DataSource = list_baudrate;
            comboBox_baud_rate.DataSource = list_baudrate;
            comboBox_baud_rate.DataSource = list_baudrate;
        }

        public form_serial()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
