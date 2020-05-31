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
    public partial class Form5 : Form
    {
        Bitmap P1 = new Bitmap("裝備升級圖.jpg");
        Bitmap P2 = new Bitmap("武器升級圖.jpg");       
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "選擇升級資訊";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = P1;
            //this.ControlBox = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "裝備升級")
            {
                pictureBox1.Image = P1;
            }
            if(comboBox1.Text == "武器升級")
            {
                pictureBox1.Image = P2;
            }            

        }
    }
}
