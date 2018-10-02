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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interpreta(InText.Lines[linea]);
            linea++;

        }

        public  List<string> Interpreta(string linea)
        {
            string[] cadenas = linea.Split('\n', '-');
            List<string> instrucc = new List<string>();
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i].Contains("="))
                {

                }
            }
            //List<string> gram = new List<string>();
            /*Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i].Contains("="))
                {
                    List<string> s = cadenas[i - 1].Split(' ').ToList();
                    s.Remove("");

                    if (!gram.Contains(s.First()))
                    {
                        //gram.Add(s.First());
                        d.Add(s.First(), new List<string>());
                        Lenguaje(d, s[0], cadenas[i]);
                    }
                    else
                    {
                        Lenguaje(d, s[0], cadenas[i]);
                    }
                }
            }
            return d;*/
            return instrucc;
        }
        public void Lenguaje(Dictionary<string, List<string>> d, string tipo, string lenguaje)
        {
            string[] a = lenguaje.Split('|', '>', ' ', '+');

            foreach (string s in a)
                if (!d[tipo].Contains(s))
                    d[tipo].Add(s);
        }
    }
}
