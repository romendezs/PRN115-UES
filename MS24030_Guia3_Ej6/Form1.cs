using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text == "")
                {
                    throw new Exception("Los campos no pueden estar vacios");
                } else if(Convert.ToDouble(txtNumero.Text) < 0)
                {
                    throw new Exception("El numero debe ser positivo");
                } else if(Convert.ToDouble(txtNumero.Text) >= 100)
                {
                    throw new Exception("El numero debe ser de dos cifras como maximo");
                } else if (!Double.TryParse(txtNumero.Text, out double result))
                {
                    throw new Exception("Se deben ingresar valores en formato numerico");
                }

                Numero numero = new Numero();

                numero.Valor = Convert.ToDouble(txtNumero.Text);

                if ((numero.Valor) <= 10)
                {
                    lblResultado.Text = "El numero es de una cifra";
                }
                else
                {
                    lblResultado.Text = "El numero es de dos cifras";
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

    public class Numero
    {
        double valor;

        public double Valor { get => valor; set => valor = value; }
    }
}
