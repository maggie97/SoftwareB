using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interprete
{
    class Circulo: Figura
    {
        int diametro;
        public Circulo(int x, int y, string tipo, string nombre, int d) : base (x, y,tipo, nombre)
        {
            diametro = d;
        }

        public override void Dibuja(Graphics g, Pen p, Brush b)
        {
            g.DrawEllipse(p, CoordX1, CoordY1, diametro,diametro);
            g.DrawString(Valor, new Font("Times New Roman", 10), b, CoordX1 + 5, CoordY1 + 10);

        }
    }
}
