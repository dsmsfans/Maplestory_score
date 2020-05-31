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
    public partial class Form1 : Form
    {
        
        
        public int teamselect = 0;
        Form2 f2 = new Form2();
        
        public Form1()
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //comboBox1.BackColor = Color.Transparent;
            //this.BackColor = Color.Transparent;
            InitializeComponent();
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            this.ControlBox = false;
            

            
            //f3.Text = label2.Text;

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Cursor = new Cursor(@"E:\C#\upgradesys\upgradesys\mm.cur");
            axWindowsMediaPlayer1.URL = "maplestory.mp3";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            f2.ShowDialog();
            //this.label2.Text = f3.Text;
        }


        

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("別急著走吧");
        }
    }
}
