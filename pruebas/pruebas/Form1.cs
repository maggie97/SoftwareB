using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string s = "Margarita";
            List<PointF[]> fig = new List<PointF[]>();
            float tam = 100;
            float ad = (s.Length % 2 != 0) ? (float)0.5 : 0;
            for (float i = 0; i < s.Length/2 + ad; i += (float)0.5) {
                if (i % 2 == 0 || i % 2 == 1) { 
                    fig.Add(new PointF[] {   new PointF(tam  / 2 + tam * i , 0), // arriba
                                    new PointF(tam * (i) , tam), // abajo izq
                                    new PointF(tam * (i+1), tam) }); //abajo derech
                }
                else
                {
                    fig.Add(new PointF[] {   new PointF(tam  / 2 + tam * i , tam), // arriba
                                    new PointF(tam * (i) , 0), // abajo izq
                                    new PointF(tam * (i+1), 0) }); //abajo derech
                }
            }
            for (int i = 0; i < fig.Count; i++){
                
                e.Graphics.DrawPolygon(new Pen(Color.Black), fig[i]);
                e.Graphics.DrawString(s[i].ToString(), new Font("Arial", 16), 
                    new SolidBrush(Color.Blue), new PointF((tam * (i+1) / 2) - 10 , (tam  / 2)- 10 ));
            }
        }
    }
}
