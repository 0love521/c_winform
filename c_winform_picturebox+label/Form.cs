using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c_winform_picturebox_label.Properties;

namespace c_winform_picturebox_label
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public void Skins(int colorcode)
        {
            switch (colorcode)
            {
                case 1:
                    label1.ForeColor = Color.FromArgb(169, 169, 169); //灰色
                    break;

                case 2:
                    label1.ForeColor = Color.FromArgb(153, 180, 209); //浅蓝色

                    break;

                case 3:
                    label1.ForeColor = Color.FromArgb(0, 120, 215); //蓝色
                    break;
            }
        }

        public void Setimg(PictureBox pictureBox)
        {
            Image Sselect = Resources.Tick_block;
            Image uSelect = Resources.NImg_transparent;
            pictureBox.Image = Sselect;
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };
            foreach (PictureBox p in pictureBoxes)
            {
                if (p.Name != pictureBox.Name)
                {
                    p.Image = uSelect;
                }
            }
        }

        public void Setbtn(int code)
        {
            switch (code)
            {
                case 1:
                    Setimg(pictureBox1);
                    Skins(code);
                    break;

                case 2:
                    Setimg(pictureBox2);
                    Skins(code);
                    break;

                case 3:
                    Setimg(pictureBox3);
                    Skins(code);
                    break;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Setbtn(1);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Setbtn(2);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Setbtn(3);
        }
    }
}