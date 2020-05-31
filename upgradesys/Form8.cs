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
    public partial class Form8 : Form
    {
        Form3 f3 = new Form3();
        Bitmap P1 = new Bitmap("1-1.jpg");
        Bitmap P2 = new Bitmap("2-1.jpg");
        Bitmap P3 = new Bitmap("3-1.jpg");
        Bitmap P4 = new Bitmap("4-1.jpg");
        Bitmap P5 = new Bitmap("5-1.jpg");
        Bitmap P6 = new Bitmap("E1-1.jpg");
        Bitmap P7 = new Bitmap("E2-1.jpg");
        Bitmap P8 = new Bitmap("E3-1.jpg");
        Bitmap P9 = new Bitmap("E4-1.jpg");
        Bitmap P10 = new Bitmap("E5-1.jpg");
        Bitmap P11 = new Bitmap("E6-1.jpg");
        Bitmap P12 = new Bitmap("E7-1.jpg");
        Bitmap P13 = new Bitmap("C1.jpg");
        Bitmap P14 = new Bitmap("C2.jpg");
        Bitmap P15 = new Bitmap("C3.jpg");
        Bitmap P16 = new Bitmap("money1.jpg");
        Bitmap P17 = new Bitmap("money2.jpg");
        Bitmap P18 = new Bitmap("money3.jpg");
        Bitmap P19 = new Bitmap("money4.jpg");
        //一星裝備
        Bitmap P20 = new Bitmap("1-2.jpg");
        Bitmap P21 = new Bitmap("2-2.jpg");
        Bitmap P22 = new Bitmap("3-2.jpg");
        Bitmap P23 = new Bitmap("4-2.jpg");
        Bitmap P24 = new Bitmap("5-2.jpg");
        Bitmap P25 = new Bitmap("E1-2.jpg");
        Bitmap P26 = new Bitmap("E2-2.jpg");
        Bitmap P27 = new Bitmap("E3-2.jpg");
        Bitmap P28 = new Bitmap("E4-2.jpg");
        Bitmap P29 = new Bitmap("E5-2.jpg");
        Bitmap P30 = new Bitmap("E6-2.jpg");
        Bitmap P31 = new Bitmap("E7-2.jpg");
        Bitmap P32 = new Bitmap("C4.jpg");
        //二星裝備
        Bitmap P33 = new Bitmap("1-3.jpg");
        Bitmap P34 = new Bitmap("2-3.jpg");
        Bitmap P35 = new Bitmap("3-3.jpg");
        Bitmap P36 = new Bitmap("4-3.jpg");
        Bitmap P37 = new Bitmap("5-3.jpg");
        Bitmap P38 = new Bitmap("E1-3.jpg");
        Bitmap P39 = new Bitmap("E2-3.jpg");
        Bitmap P40 = new Bitmap("E3-3.jpg");
        Bitmap P41 = new Bitmap("E4-3.jpg");
        Bitmap P42 = new Bitmap("E5-3.jpg");
        Bitmap P43 = new Bitmap("E6-3.jpg");
        Bitmap P44 = new Bitmap("E7-3.jpg");
        Bitmap P45 = new Bitmap("C5.jpg");
        Bitmap P46 = new Bitmap("C6.jpg");
        //三星裝備
        Bitmap P47 = new Bitmap("1-4.jpg");
        Bitmap P48 = new Bitmap("2-4.jpg");
        Bitmap P49 = new Bitmap("3-4.jpg");
        Bitmap P50 = new Bitmap("4-4.jpg");
        Bitmap P51 = new Bitmap("5-4.jpg");
        Bitmap P52 = new Bitmap("E1-4.jpg");
        Bitmap P53 = new Bitmap("E2-4.jpg");
        Bitmap P54 = new Bitmap("E3-4.jpg");
        Bitmap P55 = new Bitmap("E4-4.jpg");
        Bitmap P56 = new Bitmap("E5-4.jpg");
        Bitmap P57 = new Bitmap("E6-4.jpg");
        Bitmap P58 = new Bitmap("E7-4.jpg");
        public int finalnum = 0;
        public Form8()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if(finalnum < 20)
            {
                pictureBox1.Image = P1;
            }
            if (finalnum < 40 && finalnum > 19)
            {
                pictureBox1.Image = P2;
            }
            if (finalnum < 60 && finalnum > 39)
            {
                pictureBox1.Image = P3;
            }
            if (finalnum < 80 && finalnum > 59)
            {
                pictureBox1.Image = P4;
            }
            if (finalnum < 100 && finalnum > 79)
            {
                pictureBox1.Image = P5;
            }
            if (finalnum < 120 && finalnum > 99)
            {
                pictureBox1.Image = P6;
            }
            if (finalnum < 140 && finalnum > 119)
            {
                pictureBox1.Image = P7;
            }
            if (finalnum < 160 && finalnum > 139)
            {
                pictureBox1.Image = P8;
            }
            if (finalnum < 180 && finalnum > 159)
            {
                pictureBox1.Image = P9;
            }
            if (finalnum < 200 && finalnum > 179)
            {
                pictureBox1.Image = P10;
            }
            if (finalnum < 220 && finalnum > 199)
            {
                pictureBox1.Image = P11;
            }
            if (finalnum < 240 && finalnum > 219)
            {
                pictureBox1.Image = P12;
            }
            if (finalnum < 260 && finalnum > 239)
            {
                pictureBox1.Image = P13;
            }
            if (finalnum < 280 && finalnum > 259)
            {
                pictureBox1.Image = P14;
            }
            if (finalnum < 300 && finalnum > 279)
            {
                pictureBox1.Image = P15;
            }
            if (finalnum < 320 && finalnum > 299)
            {
                pictureBox1.Image = P16;
            }
            if (finalnum < 340 && finalnum > 319)
            {
                pictureBox1.Image = P17;
            }
            if (finalnum < 360 && finalnum > 339)
            {
                pictureBox1.Image = P18;
            }
            if (finalnum < 380 && finalnum > 359)
            {
                pictureBox1.Image = P19;
            }
            //--------------------------------------
            ////一星裝備
            //--------------------------------------
            if (finalnum < 385 && finalnum > 379)
            {
                pictureBox1.Image = P20;
            }
            if (finalnum < 390 && finalnum > 384)
            {
                pictureBox1.Image = P21;
            }
            if (finalnum < 395 && finalnum > 389)
            {
                pictureBox1.Image = P22;
            }
            if (finalnum < 400 && finalnum > 394)
            {
                pictureBox1.Image = P23;
            }
            if (finalnum < 405 && finalnum > 399)
            {
                pictureBox1.Image = P24;
            }
            if (finalnum < 410 && finalnum > 404)
            {
                pictureBox1.Image = P25;
            }
            if (finalnum < 415 && finalnum > 409)
            {
                pictureBox1.Image = P26;
            }
            if (finalnum < 420 && finalnum > 414)
            {
                pictureBox1.Image = P27;
            }
            if (finalnum < 425 && finalnum > 419)
            {
                pictureBox1.Image = P28;
            }
            if (finalnum < 430 && finalnum > 424)
            {
                pictureBox1.Image = P29;
            }
            if (finalnum < 435 && finalnum > 429)
            {
                pictureBox1.Image = P30;
            }
            if (finalnum < 440 && finalnum > 434)
            {
                pictureBox1.Image = P31;
            }
            if (finalnum < 445 && finalnum > 439)
            {
                pictureBox1.Image = P32;
            }
            //--------------------------------------
            //二星裝備
            //--------------------------------------
            if (finalnum < 448 && finalnum > 444)
            {
                pictureBox1.Image = P35;
            }
            if (finalnum < 451 && finalnum > 447)
            {
                pictureBox1.Image = P36;
            }
            if (finalnum < 454 && finalnum > 450)
            {
                pictureBox1.Image = P37;
            }
            if (finalnum < 457 && finalnum > 453)
            {
                pictureBox1.Image = P38;
            }
            if (finalnum < 460 && finalnum > 456)
            {
                pictureBox1.Image = P39;
            }
            if (finalnum < 463 && finalnum > 459)
            {
                pictureBox1.Image = P40;
            }
            if (finalnum < 466 && finalnum > 462)
            {
                pictureBox1.Image = P41;
            }
            if (finalnum < 469 && finalnum > 465)
            {
                pictureBox1.Image = P42;
            }
            if (finalnum < 472 && finalnum > 468)
            {
                pictureBox1.Image = P43;
            }
            if (finalnum < 475 && finalnum > 471)
            {
                pictureBox1.Image = P44;
            }
            if (finalnum < 478 && finalnum > 474)
            {
                pictureBox1.Image = P45;
            }
            //*****************************
            //三星裝備
            //*****************************
            if (finalnum < 480 && finalnum > 476)
            {
                pictureBox1.Image = P46;
            }
            
            if (finalnum < 482 && finalnum > 478)
            {
                pictureBox1.Image = P47;
            }
            if (finalnum < 484 && finalnum > 480)
            {
                pictureBox1.Image = P48;
            }
            if (finalnum < 486 && finalnum > 482)
            {
                pictureBox1.Image = P49;
            }
            if (finalnum < 488 && finalnum > 484)
            {
                pictureBox1.Image = P50;
            }
            if (finalnum < 490 && finalnum > 486)
            {
                pictureBox1.Image = P51;
            }
            if (finalnum < 492 && finalnum > 488)
            {
                pictureBox1.Image = P52;
            }
            if (finalnum < 494 && finalnum > 490)
            {
                pictureBox1.Image = P53;
            }
            if (finalnum < 496 && finalnum > 492)
            { 
                pictureBox1.Image = P54;
            }
            if (finalnum < 498 && finalnum > 494)
            {
                pictureBox1.Image = P55;
            }
            if (finalnum < 500 && finalnum > 496)
            {
                pictureBox1.Image = P56;
            }
            if (finalnum < 502 && finalnum > 498)
            {
                pictureBox1.Image = P57;
            }
            if (finalnum < 504 && finalnum > 500)
            {
                pictureBox1.Image = P58;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
