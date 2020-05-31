using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace upgradesys
{
    public partial class Form6 : Form
    {
        string g_str = " *******************///瘋之武器!!強力登場///*********************      瘋之黑色之劍  瘋之黑色之弓  瘋之黑色之杖  瘋隻黑色之拳  瘋之黑色之槍                                                         ";
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = g_str.Substring(0, 1);
            g_str = g_str.Substring(1, g_str.Length - 1) + temp;
            label1.Text = g_str;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
