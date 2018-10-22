
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
        List<String> LineaCodigo;
        Obj Ob;
        public Form1()
        {
            LineaCodigo = new List<string>();
            InitializeComponent();
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
            Dibuja();
        }
        public void Dibuja()
        {
            switch (Ob.Tipo1)
            {

            }
        }
        //Método que separa las siguientes lineas, asignando las acciones que se harán
        public void Interpreta(string Linea)
        {

            aux = Linea.Split(' ');
            if (linea == 2) //Contador de línea
            {
                Funcion = aux[0];
                Prueba.Text = Funcion;
            }
            if (linea == 1)
            {
                valor = aux[2];
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

        private void PanelVisual_Paint(object sender, PaintEventArgs e)
        {
            Figura f;
            int x = 0, y = 0;
            int a = 30;
            int b = 30;
            int v = Int32.Parse(valor);
            int Fac = 1;
            if (Funcion == "Factorial(a)")
            {
                for (int i = 1; i < v + 1; i++)
                {
                    Fac = Fac * i;
                    f = new Cuadro(100, 40, "Cuadrado", "c", a);
                    y = (b + 40) / 2;
                    x = (a + 20) / 2;
                    f.Dibuja(e.Graphics, new Pen(Color.Beige), new SolidBrush(Color.Black));
                    e.Graphics.DrawString(Convert.ToString(Fac), new Font("Times New Roman", 10), new SolidBrush(Color.Black), x + 5, y + 10);
                    a += 20;
                    b += 20;
                    Thread.Sleep(1000);
                }
            }
            
            /*switch (Figura.SelectedIndex)
            {
                case 0:
                    f = new Circulo(x, y, "circulo", "c", 30);
                    f.Dibuja(e.Graphics, new Pen(Color.Beige), new SolidBrush(Color.Black));
                    break;
                case 1:
                    f = new Cuadro(x, y, "Cuadrado", "c", 30);
                    f.Dibuja(e.Graphics, new Pen(Color.Beige), new SolidBrush(Color.Black));
                    break;
                case 2:
                    f = new Triangulo(x, y, "circulo", "c", 30, 30);
                    f.Dibuja(e.Graphics, new Pen(Color.Beige), new SolidBrush(Color.Black));
                    break;
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invalidate();
            PanelVisual.Invalidate();
        }

        private void BTNLinea_Click(object sender, EventArgs e)
        {
            if (linea == Max)
            {
                BTNLinea.Enabled = false;
                button1.Enabled = true;
                TBLinea.Text = "";
                MessageBox.Show("Ya no hay más lineas");
            }
            else
            {
                TBLinea.Text = InText.Lines[linea];
                Interpreta(InText.Lines[linea]);
                linea++;
            }

        } 

    }
}
