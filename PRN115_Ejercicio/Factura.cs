using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PRN115_Ejercicio
{
    internal class Venta
    {
        public const double precioAlpina = 3.50;
        public const double precioCristal = 3.00;

        //Declaring fields
        private string cliente = null;
        private int cantidad;
        private int marca;

        //Declaring properties
        public string Cliente
        {
            get { return cliente;}
            set
            {
                if(value.Length>=3){ cliente = value;}
            }
        }

        public int Cantidad
        {
            get { return cantidad;}
            set
            {
                if(value>0){ cantidad = value; }
            }
        }

        public int Marca
        {
            get { return marca; }
            set {
                if(value.ToString() == "1" || value.ToString()=="2"){ marca = value; }
            }


        }

        public string Factura()
        {
            double total;
            
            if ( marca == 1)
            {
                total = cantidad * precioAlpina;

            }else
            {
                total = cantidad * precioCristal;
            }

            string factura = $"Cliente: {this.Cliente}\n\rMarca: {(this.Marca == 2 ? "Cristal" : "Alpina")}\n\rCantidad: {this.Cantidad}\n\rTotal: ${total}";
            return factura;
        }


    }
}
