using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика04._02._2021
{
    public partial class Form1 : Form
    {
        bool Draw = false;
        bool Napr = true;
        float x = 190;
        float y = 120;
        float x_q = 0;
        float y_q = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(y_q+20 >= pictureBox1.Height)
            {
                if (Napr == true)
                {
                    Napr = false;
                }
                else
                {
                    Napr = true;
                }
            }

            if (Napr)
            {
                x_q += 1;
                y_q = (float)(0.2)* x_q * x_q;
            
            }
            else
            {
                x_q -= 1;
                y_q =(float)(0.2)*x_q * x_q;
            }
            
            pictureBox1.Invalidate();
        }

        private void But_Anim_Click(object sender, EventArgs e)
        {
            Timer.Start();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Draw)
                e.Graphics.FillEllipse(new SolidBrush(Color.DarkSeaGreen), x+(float)(2.5)*x_q, y-y_q, 15, 15);
        }

        private void But_Draw_Click(object sender, EventArgs e)
        {
            Draw = true;
            pictureBox1.Invalidate();
        }

        private void But_Del_Click(object sender, EventArgs e)
        {
            Draw = false;
            Napr = true;
            Timer.Stop();
            x_q = 0;
            y_q = 0;
            x = 190;
            y = 120;
            pictureBox1.Invalidate();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
