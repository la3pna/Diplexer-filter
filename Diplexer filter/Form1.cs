using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Diplexer_filter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fc = float.Parse(textBox1.Text);
            float k = float.Parse(textBox2.Text);
            float r = float.Parse(textBox3.Text);
            double w = 2 * Math.PI * (fc*Math.Pow(10, 6));
            double t4 = ((k * 1.5613 * r) / (w)) * Math.Pow(10, 6);
            double t5 = ((k*1.8069)/(r*w))*Math.Pow(10, 12);
            double t6 = ((k * 1.7659 * r) / (w)) * Math.Pow(10, 6);
            double t7 = ((k * 1.4173) / (r * w)) * Math.Pow(10, 12);
            double t8 = ((k * 0.6507 * r) / (w)) * Math.Pow(10, 6);

            double t9 = ((0.6405) / (r * k * w)) * Math.Pow(10, 12);
            double t10 = (( 0.5534 * r) / (k * w)) * Math.Pow(10, 6);
            double t11 = ((0.5663) / (r * k * w)) * Math.Pow(10, 12);
            double t13 = ((0.7056 * r) / (k * w)) * Math.Pow(10, 6);
            double t12 = ((1.5368) / (r * k * w)) * Math.Pow(10, 12);
            


          

            //Math.Pow(10, 12)
            // String.Format("{0:0.00}", (ser))
            textBox4.Text = Convert.ToString(String.Format("{0:0.000}", (t4)));
            textBox5.Text = Convert.ToString(String.Format("{0:0.00}", (t5)));
            textBox6.Text = Convert.ToString(String.Format("{0:0.000}", (t6)));
            textBox7.Text = Convert.ToString(String.Format("{0:0.00}", (t7)));
            textBox8.Text = Convert.ToString(String.Format("{0:0.000}", (t8)));
            textBox9.Text = Convert.ToString(String.Format("{0:0.00}", (t9)));
            textBox10.Text = Convert.ToString(String.Format("{0:0.000}", (t10)));
            textBox11.Text = Convert.ToString(String.Format("{0:0.00}", (t11)));
            textBox12.Text = Convert.ToString(String.Format("{0:0.00}", (t12)));
            textBox13.Text = Convert.ToString(String.Format("{0:0.000}", (t13)));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "la3pna@gmail.com";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Stream myStream ; 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 

            saveFileDialog1.Filter = "SPICE FILE (*.asc)|*.asc|All files (*.*)|*.*" ; 
            saveFileDialog1.FilterIndex = 1 ; 
            saveFileDialog1.RestoreDirectory = true ; 

            if(saveFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                  if((myStream = saveFileDialog1.OpenFile()) != null) 
                  { 
                        StreamWriter wText =new StreamWriter(myStream);

                        wText.WriteLine("Version 4");
                        wText.WriteLine("SHEET 1 880 680");
                        wText.WriteLine("WIRE -48 -16 -64 -16");
                        wText.WriteLine("WIRE 64 -16 32 -16");
                        wText.WriteLine("WIRE 112 -16 64 -16");
                        wText.WriteLine("WIRE 112 0 112 -16");
                        wText.WriteLine("WIRE 224 0 192 0");
                        wText.WriteLine("WIRE 256 0 224 0");
                        wText.WriteLine("WIRE 384 0 336 0");
                        wText.WriteLine("WIRE 432 0 384 0");
                        wText.WriteLine("WIRE 544 0 512 0");
                        wText.WriteLine("WIRE 224 16 224 0");
                        wText.WriteLine("WIRE 384 16 384 0");
                        wText.WriteLine("WIRE 544 16 544 0");
                        wText.WriteLine("WIRE -64 32 -64 -16");
                        wText.WriteLine("WIRE 64 32 64 -16");
                        wText.WriteLine("WIRE 224 96 224 80");
                        wText.WriteLine("WIRE 384 96 384 80");
                        wText.WriteLine("WIRE 544 96 544 80");
                        wText.WriteLine("WIRE -64 144 -64 112");
                        wText.WriteLine("WIRE 64 208 64 96");
                        wText.WriteLine("WIRE 128 208 64 208");
                        wText.WriteLine("WIRE 192 208 128 208");
                        wText.WriteLine("WIRE 320 208 256 208");
                        wText.WriteLine("WIRE 368 208 320 208");
                        wText.WriteLine("WIRE 512 208 432 208");
                        wText.WriteLine("WIRE 512 224 512 208");
                        wText.WriteLine("WIRE 128 304 128 288");
                        wText.WriteLine("WIRE 320 304 320 288");
                        wText.WriteLine("WIRE 512 320 512 304");
                        wText.WriteLine("FLAG 128 304 0");
                        wText.WriteLine("FLAG 320 304 0");
                        wText.WriteLine("FLAG 512 320 0");
                        wText.WriteLine("FLAG 384 96 0");
                        wText.WriteLine("FLAG 224 96 0");
                        wText.WriteLine("FLAG -64 144 0");
                        wText.WriteLine("FLAG 544 96 0"); //END of all tedious wiring
                        wText.WriteLine("SYMBOL res 496 208 R0");
                        wText.WriteLine("SYMATTR InstName R1");
                        wText.Write("SYMATTR Value ");
                        wText.WriteLine(textBox3.Text);
                        wText.WriteLine("SYMBOL cap 48 32 R0");
                        wText.WriteLine("SYMATTR InstName C1");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox9.Text);
                        wText.WriteLine("p");
                        wText.WriteLine("SYMBOL cap 208 16 R0");
                        wText.WriteLine("SYMATTR InstName C2");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox5.Text);
                        wText.WriteLine("p");
                        wText.WriteLine("SYMBOL cap 368 16 R0");
                        wText.WriteLine("SYMATTR InstName C3");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox7.Text);
                        wText.WriteLine("p");
                        wText.WriteLine("SYMBOL cap 256 192 R90");
                        wText.WriteLine("WINDOW 0 0 32 VBottom 2");
                        wText.WriteLine("WINDOW 3 32 32 VTop 2");
                        wText.WriteLine("SYMATTR InstName C4");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox11.Text);
                        wText.WriteLine("p");
                        wText.WriteLine("SYMBOL cap 432 192 R90");
                        wText.WriteLine("WINDOW 0 0 32 VBottom 2");
                        wText.WriteLine("WINDOW 3 32 32 VTop 2");
                        wText.WriteLine("SYMATTR InstName C5");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox12.Text);
                        wText.WriteLine("p");
                        wText.WriteLine("SYMBOL ind 208 16 M270");
                        wText.WriteLine("WINDOW 0 32 56 VTop 2");
                        wText.WriteLine("WINDOW 3 5 56 VBottom 2");
                        wText.WriteLine("SYMATTR InstName L1");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox4.Text);
                        wText.WriteLine("µ");
                        wText.WriteLine("SYMBOL ind 352 16 M270");
                        wText.WriteLine("WINDOW 0 32 56 VTop 2");
                        wText.WriteLine("WINDOW 3 5 56 VBottom 2");
                        wText.WriteLine("SYMATTR InstName L2");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox6.Text);
                        wText.WriteLine("µ");
                        wText.WriteLine("SYMBOL ind 528 16 M270");
                        wText.WriteLine("WINDOW 0 32 56 VTop 2");
                        wText.WriteLine("WINDOW 3 5 56 VBottom 2");
                        wText.WriteLine("SYMATTR InstName L3");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox8.Text);
                        wText.WriteLine("µ");
                        wText.WriteLine("SYMBOL ind 144 192 M0");
                        wText.WriteLine("SYMATTR InstName L4");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox10.Text);
                        wText.WriteLine("µ");
                        wText.WriteLine("SYMBOL ind 336 192 M0");
                        wText.WriteLine("SYMATTR InstName L5");
                        wText.Write("SYMATTR Value ");
                        wText.Write(textBox13.Text);
                        wText.WriteLine("µ");
                        wText.WriteLine("SYMBOL voltage -64 16 R0");
                        wText.WriteLine("WINDOW 123 0 0 Left 2");
                        wText.WriteLine("WINDOW 39 0 0 Left 2");
                        wText.WriteLine("SYMATTR InstName V1");
                        wText.WriteLine("SYMATTR Value AC 2");
                        wText.WriteLine("SYMBOL res 48 0 M270");
                        wText.WriteLine("WINDOW 0 32 56 VTop 2");
                        wText.WriteLine("WINDOW 3 0 56 VBottom 2");
                        wText.WriteLine("SYMATTR InstName R2");
                        wText.Write("SYMATTR Value ");
                        wText.WriteLine(textBox3.Text);
                        wText.WriteLine("SYMBOL res 528 -16 R0");
                        wText.WriteLine("SYMATTR InstName R3");
                        wText.Write("SYMATTR Value ");
                        wText.WriteLine(textBox3.Text);
                        wText.WriteLine("TEXT 200 344 Left 2 !.ac lin 500 1meg 30meg");
                       
                        wText.Flush();
                        wText.Close();
                        label5.Text = "SAVED";
                  } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
