using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdernar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtN1.Text == "") || (txtN2.Text == "")|| (txtN3.Text == ""))
                {
                    throw new Exception("Los campos no pueden estar vacios");
                }

                Ordenar numerosIngresados = new Ordenar();

                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double n3 = Convert.ToDouble(txtN3.Text);

                double[] numeros = new double[] { n1, n2, n3 };
                Array.Sort(numeros);

                numerosIngresados.Numeros = numeros;

                foreach(double o in numerosIngresados.Numeros)
                {
                    lblResultados.Text += "\n" + o.ToString() ;
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

    public class Ordenar
    {
        private double[] numeros = new double[3];
        public double[] Numeros { get => numeros; set => numeros = value; }
    }
}
