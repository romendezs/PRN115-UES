using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConsumo.Text == "")
                {
                    throw new Exception("Los campos no peuden estar vacios");
                }

                Factura factura = new Factura();

                factura.Monto = Convert.ToDouble(txtConsumo.Text);
                factura.calcularDescuento();

                if (factura.Descuento == 0)
                {
                    MessageBox.Show($"Total: ${factura.Total} \nPasar a Caja por un cupón Promocional");
                }else
                {
                    MessageBox.Show($"Total: ${factura.Total} \nDescuento aplicado (25%): ${factura.Descontar}");
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Factura
    {
        private double monto;
        private int descuento;

        private double total;
        private double descontar;

        public double Monto { 
            get => monto; 
            set { if (value != null) { monto = value; } } 
        }
        public int Descuento
        {
            get => descuento;
            set {  descuento = value; }
        }

        public double Total { get => total; set => total = value; }
        public double Descontar { get => descontar; set => descontar = value; }

        public int calcularDescuento()
        {
            if (this.Monto > 30)
            {
                this.Descuento = 25;
                this.Descontar = this.Monto * 0.25;
                this.Total = this.Monto - this.Descontar;
            }
            else
            {
                this.Descuento = 0;
                this.Total = this.Monto;
            };

            return descuento;
        }
    }
}
