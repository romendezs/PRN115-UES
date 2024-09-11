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

namespace MS24030_Guia3_Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex validarProducto = new Regex("^[a-zA-Z]+$");
            
            if (validarProducto.IsMatch(txtRepuesto.Text))
            {
                //Creating new Repuesto and setting props
                Repuesto nuevoRepuesto = new Repuesto();
                nuevoRepuesto.Producto = txtRepuesto.Text;
                nuevoRepuesto.Precio = Convert.ToDouble(nudPrecio.Text);
                nuevoRepuesto.ManoObra = Convert.ToDouble(nudManoObra.Text);

                //Adding in the DataGrid
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvFactura);

                fila.Cells[0].Value = nuevoRepuesto.Producto;
                fila.Cells[1].Value = nuevoRepuesto.Precio.ToString();
                fila.Cells[2].Value = nuevoRepuesto.ManoObra.ToString();

                dgvFactura.Rows.Add(fila);

            }
            else
            {
                MessageBox.Show("Debe completar correctamente el campo de Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total =0;
            
            //Summ of the monto
            for( int i = 0; i< dgvFactura.Rows.Count; i++)
            {
                if (!dgvFactura.Rows[i].IsNewRow)
                {
                    total += Convert.ToDouble(dgvFactura.Rows[i].Cells[1].Value) + Convert.ToDouble(dgvFactura.Rows[i].Cells[2].Value);
                }
            }

            lblTotal.Text = $"Total: {total.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Repuesto
    {
        private string producto;
        private double precio;
        private double manoObra;

        public string Producto { get => producto; set => producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public double ManoObra { get => manoObra; set => manoObra = value; }

    }
}
