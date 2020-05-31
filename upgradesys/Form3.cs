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
    public partial class Form3 : Form
    {
        
        //Form8 f8 = new Form8();
        Random rnd1 = new Random();
        public int randnum = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            randnum = rnd1.Next(380,503);
            f7.checknum = this.randnum;
            f7.ShowDialog();            
            this.Close();
        }
    }
}
