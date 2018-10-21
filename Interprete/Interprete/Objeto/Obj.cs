using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete
{
    class Obj
    {
        Figura f;
        string Tipo;
        string nomb;

        public Figura F { get => f; set => f = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Nomb { get => nomb; set => nomb = value; }

        public Obj(string tipo, string nombre)
        {
            this.Tipo = tipo;
            nomb = nombre;
        }

        public void creaFig()
        {

        }
        //Método para buscar el tipo del objeto (Entero, cadena o carácter)
        public void Busco()
        {
            switch (Tipo)
            {
                case "int":
                    break;
                case "float":
                    break;
                case "char":
                    break;
                case "string":
                    break;
            }
        }
    }
}
