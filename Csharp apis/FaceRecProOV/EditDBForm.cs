using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MultiFaceRec
{
    public partial class EditDBForm : Form
    {
        
        public EditDBForm ()
        {
            InitializeComponent();
            listbox_load();
            populate("All users");
            
            
        }
        public void listbox_load()
        {
            listBox1.Items.Add("All users");
            string[] all_names;
            string Allnames_file = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
            all_names = Allnames_file.Split('%');
            all_names = Allnames_file.Split('%');
            //int num_names = Convert.ToInt16(all_names[0]);
            for (int i = 1; i < all_names.Length - 1; i++)
            {
                if (strcmp(all_names[i], all_names[i + 1]) != 0)
                {
                    listBox1.Items.Add(all_names[i]);
                }

            }
        }

        void populate(string option)
        {
            panel1.Controls.Clear();
            string[] all_names;
            PictureBox[] pic_box_list;
            String[] pics_list;
            pics_list = Directory.GetFiles(@"H:\brian\Documents\MEEC\lab_integrados_II\1617-MEEC-LI2-9575-9689-9980-14252\Csharp apis\FaceRecProOV\bin\Debug\TrainedFaces", "*.bmp");
            //pics_list = Array.Sort(pics_list, new AlphanumericComparatorFast());
            //for (int i = 0; i < pics_list.Length; i++)
            //{
            //    var x_1 = pics_list[i];
            //    var j = i;
            //    while (j > 0 && pics_list[j - 1].CompareTo(x_1) > 0)
            //    {
            //        pics_list[j] = pics_list[j - 1];
            //        j = j - 1;
            //    }
            //    pics_list[j] = x_1;
            //}

            string Allnames_file = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
            all_names = Allnames_file.Split('%');
            int x = 20;
            int y = 20;
            pic_box_list = new PictureBox[pics_list.Length];

            for (int i = 0; i < pics_list.Length; i++)
            {
                if ((strcmp(option, all_names[i + 1]) == 0) && (strcmp(option,"All users") != 0))
                {
                    pic_box_list[i] = new PictureBox();
                    pic_box_list[i].Image = Image.FromFile(pics_list[i]);
                    pic_box_list[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    pic_box_list[i].Location = new Point(x, y);
                    x += pic_box_list[i].Width + 10;
                    if (x > panel1.Width - 50)
                    {
                        x = 20;
                        y += pic_box_list[i].Height + 10;
                    }
                    this.panel1.Controls.Add(pic_box_list[i]);
                } else if (strcmp(option, "All users") == 0)
                {
                    pic_box_list[i] = new PictureBox();
                    pic_box_list[i].Image = Image.FromFile(pics_list[i]);
                    pic_box_list[i].SizeMode = PictureBoxSizeMode.AutoSize;
                    pic_box_list[i].Location = new Point(x, y);
                    x += pic_box_list[i].Width + 10;
                    if (x > panel1.Width - 50)
                    {
                        x = 20;
                        y += pic_box_list[i].Height + 10;
                    }
                    this.panel1.Controls.Add(pic_box_list[i]);
                }
               
            }
            //string GPIOinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/GPIOPreferences.txt");
            
        }
        public static int strcmp (string st1, string st2)
        {
            int iST1 = 0, iST2 = 0;
            for (int i = 0; i < (st1.Length > st2.Length ? st1.Length : st2.Length); i++)
            {
                iST1 += (i >= st1.Length ? 0 : st1[i]) - (i >= st2.Length ? 0 : st2[i]);
                if (iST2 < 0)
                {
                    if (iST1 < 0)
                        iST2 += iST1;
                    if (iST1 > 0)
                        iST2 += -iST1;
                }
                else
                {
                    iST2 += iST1;
                }
            }
            return iST2;
        }

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            string option_selected = listBox1.SelectedItem.ToString();
            populate(option_selected);
        }
    }
}
