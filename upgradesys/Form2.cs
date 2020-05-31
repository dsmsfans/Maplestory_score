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
    public partial class Form2 : Form
    {
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form9 f9 = new Form9();
        Form10 f10 = new Form10();
        string g_str = "4星裝備粉墨登場!!!快來抽喔~~    ";
        public Form2()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //f4.ShowDialog();
            f3.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string temp = g_str.Substring(0, 1);
            g_str = g_str.Substring(1, g_str.Length - 1) + temp;
            label5.Text = g_str;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f5.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            f6.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            f9.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("白狼王!!");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            f10.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
