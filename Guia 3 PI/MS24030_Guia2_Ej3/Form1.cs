using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia2_Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
                if (txtN1.Text == "" || txtN2.Text == "")
                {
                    throw new Exception("Los campos no pueden estar vacios");
                }

                nuevoNumero numero = new nuevoNumero();
                numero.N1 = Convert.ToDouble(txtN1.Text);
                numero.N2 = Convert.ToDouble(txtN2.Text);

                if (numero.N1 != numero.N2)
                {
                    if(numero.N1 > numero.N2)
                    {
                        lblResultado.Text = $"{numero.N1} es mayor que {numero.N2}";
                    }
                    else
                    {
                        lblResultado.Text = $"{numero.N2} es mayor que {numero.N1}";
                    }
                }
                else
                {
                    lblResultado.Text = $"Los numeros son iguales";
                }

                txtN1.Text = "";
                txtN2.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class nuevoNumero
    {
        private double n1;
        private double n2;

        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }
    }
}
