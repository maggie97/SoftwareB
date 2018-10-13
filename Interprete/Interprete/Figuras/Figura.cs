using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interprete
{
    class Figura
    {
        string valor;
        string Nombre;
        string Tipo;
        int CoordX;
        int CoordY;

        public Figura(int x, int y, string tipo, string nombre)
        {
            Nombre = nombre;
            Tipo = tipo;
            CoordX = x;
            CoordY = y;
            valor = "";
        }

        public virtual void Dibuja(Graphics g, Pen p, Brush b)
        {

        }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public int CoordX1 { get => CoordX; set => CoordX = value; }
        public int CoordY1 { get => CoordY; set => CoordY = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}
