using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interprete
{
    public partial class Form1 : Form
    {
        int linea = 0;
        List<Object> obj;
        public Form1()
        {
            InitializeComponent();
            obj = new List<object>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(InText.Lines[linea]);
            Interpreta(InText.Lines[linea]);
            linea++;

        }

        public  List<string> Interpreta(string linea)
        { 
            List<string> instrucc = new List<string>();
            if (linea.Contains("=")) // Asignacion;
            {
                string[] cadenas = linea.Split('='); //Asigna Valores 
                if (cadenas.First().Contains("int"))
                {
                    if(cadenas.Length < 3)
                    {
                        //obj(new int())
                    }
                } 
            }
            else //Crea Variables 
            {

            }
            return instrucc;
        }
    }
}
