using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interprete
{
    class Obj
    {
        private Figura f;
        private string Tipo;
        private string nomb;
        private object valor;


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
            f = new Figura(100, 40, Tipo, Nomb);
        }
        //Método para buscar el tipo del objeto (Entero, cadena o carácter)
        public void Busco()
        {
            if(Tipo == "string")
            {
                
            }
            else
            {

            }
        }
        public virtual void RegresaTipo() {

        }
    }
}
