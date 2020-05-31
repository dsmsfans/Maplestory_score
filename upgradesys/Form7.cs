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
    public partial class Form7 : Form
    {
        int time = 0;
        Form8 f8 = new Form8();
        public int checknum;
        public Form7()
        {
            InitializeComponent();
            //this.timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            //this.ControlBox = false;
            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time == 50)
            {
                this.timer1.Stop();
                f8.finalnum = this.checknum;
                f8.ShowDialog();
                time = 0;
                this.Close();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
