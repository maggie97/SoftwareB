using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cuadros
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        int x, y;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            p = new Pen(Color.Black, 4);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //label1.Text=
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 30;
            int b = 30;
            x = 0;
            y = 0;
            int n = 8;
            int Fac = 1;
            SolidBrush Sb = new SolidBrush(Color.Red);
            for (int i = 1; i < n; i++) //Factorial de n-1
            {
                Fac = Fac * i;
                g.DrawEllipse(p, 20, 40, a, b);
                y = (b + 40) / 2;
                x = (a + 20) / 2;
                x = x - (Fac.ToString().Length *2);
                g.DrawString(Convert.ToString(Fac), new Font("Times New Roman", 10), Sb, x+5, y + 10);
                a += 20;
                b += 20;
                Thread.Sleep(1000);
                g.Clear(Color.White);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 30;
            int b = 30;
            x = 0;
            y = 0;
            int Fac = 1;
            int n = 8;
            SolidBrush Sb = new SolidBrush(Color.Red);
            for (int i = 1; i < n; i++) //n-1
            {
                Fac = Fac * i;
                g.DrawRectangle(p, 20, 40, a, b);
                y = (b + 40)/2;
                x = (a + 20)/2;
                x = x - Fac.ToString().Length;
                g.DrawString(Convert.ToString(Fac), new Font("Times New Roman", 10), Sb, x+5, y+10);
                a += 20;
                b += 20;
                Thread.Sleep(1000);
                g.Clear(Color.White);
            }
        }
    }
}
