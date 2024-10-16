using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_4_PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            try
            {
                Regex validarInt = new Regex("^[1-9]+\\d*$");
                Regex validarDouble = new Regex("^[1-9]+\\d*(.\\d*)?$");

                if (!validarInt.IsMatch(txtUnidades.Text))
                {
                    throw new Exception("Por favor ingrese un numero mayor a cero");
                }
                else
                {
                    Compra compra = new Compra();
                    compra.Unidades = Convert.ToInt32(txtUnidades.Text);
                    compra.CacularDescuento();
                    compra.CalcularMonto();

                    string message = $"Total a pagar: ${compra.Monto} \nDescuento aplicado: {compra.Descuento*100}%";

                    MessageBox.Show(message, "Total compra", MessageBoxButtons.OK);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public class Compra
    {
        private const double precioUnitario = 650;
        private int unidades;
        private double descuento;
        private double monto;

        public int Unidades { get => unidades; set => unidades = value; }
        public double Descuento { get => descuento; }
        public double Monto { get => monto; set => monto = value; }

        public void CacularDescuento()
        {
            if (unidades < 5)
            {
                descuento = 0.1;
            } else if (unidades>=5 && unidades <10) {
                descuento = 0.2;
            } else
            {
                descuento = 0.4;
            }
        }

        public void CalcularMonto()
        {
            monto = (precioUnitario * unidades) - (precioUnitario * unidades * descuento);
        }

    }
}
