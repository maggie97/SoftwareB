
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interprete
{
    public partial class Form1 : Form
    {
        int linea;
        int Max;
        string[] aux;
        string Funcion;
        string valor = "0";
        Graphics g;
        Figura f;
        List<String> LineaCodigo;
        Obj Ob;
        public Form1()
        {
            
            LineaCodigo = new List<string>();
            InitializeComponent();
            g = PanelVisual.CreateGraphics();
        }
        //Evento del botón Interpreta
        private void button1_Click(object sender, EventArgs e)
        {
            linea = 0;
            Max = InText.Lines.Length;
            BTNLinea.Enabled = true;
            button1.Enabled = false;
            TBLinea.Text = InText.Lines[linea]; //Enseña la línea sobre la que está trabajando
            InterpretaOBJ(InText.Lines[linea]); //Llama al método de Interpreta, para buscar el tipo
            linea++;

        }
        //Método que separa la primer línea, creando el objeto del tipo que se le indica
        public void InterpretaOBJ(string linea)
        {
            aux = linea.Split(' ');
            Ob = new Obj(aux[0], aux[1]);
            if(Ob.Tipo1 == "int")
            {
                f = new Cuadro(100, 40, "Cuadrado", "c", 30);
                f.Dibuja(g, new Pen(Color.Beige), new SolidBrush(Color.Black));
            }
            else if (Ob.Tipo1 == "float")
            {
                f = new Circulo(100, 40, "Circulo", "c", 30);
                f.Dibuja(g, new Pen(Color.Beige), new SolidBrush(Color.Black));
            }
            else if(Ob.Tipo1 == "char")
            {
                f = new Triangulo(100, 40, "Triangulo", "c", 100);
                f.Dibuja(g, new Pen(Color.Beige, 2), new SolidBrush(Color.Black));
            }
        }

        //Método que separa las siguientes lineas, asignando las acciones que se harán
        public void Interpreta(string Linea)
        {
            string[] l;
            aux = Linea.Split(' ');
            if (linea == 2) //Contador de línea
            {
                l = aux[0].Split('.','(');
                Funcion = l[1];
                Prueba.Text = Funcion;
            }
            if (linea == 1)
            { 
                valor = aux[2].ToString();
                f.Valor = valor;
            }

        }
        public void Lenguaje(Dictionary<string, List<string>> d, string tipo, string lenguaje)
        {
            string[] a = lenguaje.Split('|', '>', ' ', '+');

            foreach (string s in a)
                if (!d[tipo].Contains(s))
                    d[tipo].Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void DibujaFigura(ref int x, ref int y, ref int Fac,ref int a, ref int b)
        {
            g.Clear(Color.Silver);
            y = (b + 40) / 2;
            x = (a + 20) / 2;
            f.Dibuja(g, new Pen(Color.Beige), new SolidBrush(Color.Black));
            g.DrawString(Convert.ToString(Fac), new Font("Times New Roman", 10), new SolidBrush(Color.Black), x + 5, y + 10);
            a += 20;
            b += 20;
            Thread.Sleep(1000);
        }
        private void PanelVisual_Paint(object sender, PaintEventArgs e)
        {
            int x = 0, y = 0;
            int a = 30;
            int b = 30;
            int v = 0;
            if (f != null)
            {
                if (f.Tipo1 != "Triangulo")
                    v = Int32.Parse(valor);
                f.Dibuja(g, new Pen(Color.Beige), new SolidBrush(Color.Black));
            }
            int Fac = 1;
            if (Funcion == "Factorial")
            {
                if (Ob.Tipo1 == "int")
                {
                    for (int i = 1; i < v + 1; i++)
                    {
                        Fac = Fac * i;
                        f = new Cuadro(100, 40, "Cuadrado", "c", a);
                        DibujaFigura(ref x, ref y, ref Fac, ref a, ref b);
                    }
                }
                Funcion = "";
            }
            else if(Funcion == "Duplica")
            {
                if(Ob.Tipo1 == "float")
                {
                    a = a * v;
                    b = b * v;
                    f = new Circulo(100, 40, "Circulo", "c", a);
                    
                    DibujaFigura(ref x, ref y, ref Fac, ref a, ref b);
                }
                
            }
            Funcion = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invalidate();
            PanelVisual.Invalidate();
        }

        private void BTNLinea_Click(object sender, EventArgs e)
        {
            if (linea == Max-1)
            {
                TBLinea.Text = InText.Lines[linea];
                Interpreta(InText.Lines[linea]);
                BTNLinea.Enabled = false;
                button1.Enabled = true;
                Invalidate();
                PanelVisual.Invalidate();
                //MessageBox.Show("Ya no hay más lineas");
            }
            else
            {
                TBLinea.Text = InText.Lines[linea];
                Interpreta(InText.Lines[linea]);
                linea++;
                Invalidate();
                PanelVisual.Invalidate();
            }

        } 

    }
}
