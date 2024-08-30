using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text == "")
            {
                MessageBox.Show("Ha ocurrdo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                NuevoNumero nuevoNumero = new NuevoNumero();
                nuevoNumero.Numero = Convert.ToDouble(txtNumero.Text);

                if ((nuevoNumero.Numero % 2) == 0)
                {
                    lblResultado.Text = "El numero es par";
                }
                else
                {
                    lblResultado.Text = "El numero es impar";
                }

                txtNumero.Text = "";

            }

        }
    }
}
