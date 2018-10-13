using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interprete
{
    class Cuadro : Figura
    {
        int lado;
        public Cuadro(int x, int y, string tipo, string nombre, int l) : base(x, y, tipo, nombre)
        {
            lado = l;
        }

        public override void Dibuja(Graphics g, Pen p, Brush b)
        {
            g.DrawRectangle(p, CoordX1, CoordY1, lado, lado);
            g.DrawString(Valor, new Font("Times New Roman", 10), b, CoordX1 + 5, CoordY1 + 10);

        }
    }
}
