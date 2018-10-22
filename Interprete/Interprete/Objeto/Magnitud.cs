using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete.Objeto
{
    class Magnitud : Obj
    {
        private string ti;
        public Magnitud(string tipo, string nombre) : base(tipo, nombre)
        {
            ti = tipo;
        }

        public override void RegresaTipo()
        {
            switch (ti)
            {
                case "int":
                    break;
                case "float":
                    break;
                case "char":
                    break;
            }
        }
    }
}
