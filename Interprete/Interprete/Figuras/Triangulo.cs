using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Interprete
{
    class Triangulo : Figura
    {
        int b, altura;
        int orientacion;
        PointF[] puntos;

        public Triangulo(int x, int y, string tipo, string nombre, int h) : base(x, y, tipo, nombre)
        {
            b = altura = h;
            puntos = new PointF []{ new PointF((altura  / 2 ) +x  , y), // arriba
                                    new PointF(x , b + y ), // abajo izq
                                    new PointF(altura+x , b + y )};
        } 
        public override void Dibuja(Graphics g, Pen pen, Brush b)
        {
            g.DrawString(Nombre1, new Font("Arial", 16), b, CoordX1 + (this.b/4) , CoordY1 - 25);
            g.DrawPolygon(pen,  puntos);
            g.DrawString(Valor, new Font("Arial", 16), b,
                new PointF((altura / 2) - 10 + CoordX1, (this.b / 2) - 10 + CoordY1) );
        }


    }
}
