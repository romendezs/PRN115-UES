using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


///summary
///
namespace MS24030_Guia3_Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msg = "";
            Regex precio = new Regex("^[1-9]\\d*(?:\\.\\d+)*$");
            Regex nombre = new Regex("^[a-zA-z]{3,}$");

            if(txtGasolinera.Text=="" || txtSuper.Text=="" || txtRegular.Text=="" || txtDiesel.Text == "")
            {
                msg += "Debe completar todos los campos";
            } else if(!precio.IsMatch(txtSuper.Text) || !precio.IsMatch(txtRegular.Text) || !precio.IsMatch(txtDiesel.Text))
            {
                msg += "Los campos ingresados deben ser numeros reales mayores a cero";
            } else if (!nombre.IsMatch(txtGasolinera.Text))
            {
                msg += "Gasolinera debe ser una cadena de caracteres sin espacios";
            }
            else
            {
                Gasolinera gasolinera = new Gasolinera();
                gasolinera.Super = Convert.ToDouble(txtSuper.Text);
                gasolinera.Regular = Convert.ToDouble(txtRegular.Text);
                gasolinera.Diesel = Convert.ToDouble(txtDiesel.Text);
                gasolinera.NombreGasolinera = txtGasolinera.Text;

                //Creating new rows
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvGasolineras);

                row.Cells[0].Value = gasolinera.NombreGasolinera;
                row.Cells[1].Value = gasolinera.Super;
                row.Cells[2].Value = gasolinera.Regular;
                row.Cells[3].Value = gasolinera.Diesel;

                //Printing info
                dgvGasolineras.Rows.Add(row);
            }

            if (!(msg == ""))
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Gasolinera
    {
        private string nombreGasolinera;
        private double super;
        private double regular;
        private double diesel;

        public double Super { get => super; set => super = value; }
        public double Regular { get => regular; set => regular = value; }
        public double Diesel { get => diesel; set => diesel = value; }
        public string NombreGasolinera { get => nombreGasolinera; set => nombreGasolinera = value; }
    }
}
