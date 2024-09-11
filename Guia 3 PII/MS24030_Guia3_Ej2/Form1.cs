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

namespace MS24030_Guia3_Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtAcreditar_Click(object sender, EventArgs e)
        {
            txtBeneficiado.Enabled = false;
        }

        private void rbtDebitar_Click(object sender, EventArgs e)
        {
            txtBeneficiado.Enabled = true;
        }

        private void btnEfectuar_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(rbtAcreditar.Checked==false && rbtDebitar.Checked == false)
            {
                msg += "Debe  seleccionar una transaccion \n";

            } else if(rbtDebitar.Checked==true && txtBeneficiado.Text == "")
            {
                msg += "Debe Completar todos los campos \n";

            }
             else if (rbtDebitar.Checked == true && !(new Regex("^[a-zA-Z]+$").IsMatch(txtBeneficiado.Text)) )
            {
                msg += "Solo puede ingresar letras";
            }
            else
            {
                Transaccion transaccion = new Transaccion();
                transaccion.TipoTransaccion = (rbtAcreditar.Checked == true) ? "Acreditar" : "Debitar";
                transaccion.Cantidad = Convert.ToDouble(nudCantidad.Value);
                transaccion.Beneficiado = (rbtDebitar.Checked==true)?txtBeneficiado.Text:"Propietario";

                //Creating new fila
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvTransacciones);

                fila.Cells[0].Value= (transaccion.TipoTransaccion=="Debitar")? (-transaccion.Cantidad): (transaccion.Cantidad);
                fila.Cells[1].Value = transaccion.Beneficiado;
                dgvTransacciones.Rows.Add(fila);

                //Remaining in the account
                double saldo = 0;

                for (int i=0; i<dgvTransacciones.RowCount; i++)
                {
                    if (!dgvTransacciones.Rows[i].IsNewRow)
                    {
                        saldo += Convert.ToDouble(dgvTransacciones.Rows[i].Cells[0].Value);   
                    }
                }

                transaccion.Saldo = saldo;
                lblSaldo.Text = $"Saldo Actual: ${transaccion.Saldo.ToString()}";


            }

            if (msg != "")
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Transaccion
    {
        private string tipoTransaccion;
        private double cantidad;
        private string beneficiado;
        private double saldo = 0;

        public string TipoTransaccion { get => tipoTransaccion; set => tipoTransaccion = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public string Beneficiado { get => beneficiado; set => beneficiado = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}
