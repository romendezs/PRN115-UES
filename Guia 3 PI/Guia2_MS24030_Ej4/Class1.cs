using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2_MS24030_Ej4
{
    internal class Estudiante
    {
        private string nombre = "";
        private double nota;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Length > 3)
                {
                    nombre = value;
                };
            }
        }

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value > 0 & value <= 10)
                {
                    nota = value;
                };
            }
        }
    }
}
