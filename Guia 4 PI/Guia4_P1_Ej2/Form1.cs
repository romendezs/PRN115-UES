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

namespace Guia4_P1_Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            try
            {

                Regex validarInt = new Regex("^\\d+$");
                Regex validarHoras = new Regex("^[1-9]+\\d*$");

                Regex validarDouble = new Regex("^[1-9]+(.\\d+)?$");
                Regex validarNombre = new Regex("^\\w+(\\s\\w+){0,3}$");

                if(!validarHoras.IsMatch(txtHoras.Text) || !validarInt.IsMatch(txtYears.Text) || !validarDouble.IsMatch(txtSalario.Text) || !validarNombre.IsMatch(txtNombre.Text))
                {

                    //Handling errors
                    string msg = "";
                    if (!validarHoras.IsMatch(txtHoras.Text)) {
                        msg += "\nRevise el campo de Horas, solo puede ingresar enteros mayores a cero";

                    } if (!validarInt.IsMatch(txtYears.Text)) {
                        msg += "\nRevise el campo de Años trabajando, solo puede ingresar enteros positivos o cero";

                    } if (!validarDouble.IsMatch(txtSalario.Text)){
                        msg += ("\nRevise el campo de Salario por hora, solo puede ingresar numeros positivos");

                    }
                    if (!validarNombre.IsMatch(txtNombre.Text))
                    {
                        msg += ("\nRevise el campo de Nombre empleado, solo puede ingresar cuatro palabras");
                    }

                    throw new Exception(msg);
                
                }
                else
                {

                    //Creating new empleado
                    Empleado empleado = new Empleado(
                        Convert.ToDouble(txtSalario.Text), 
                        txtNombre.Text, 
                        Convert.ToInt32(txtYears.Text),
                        Convert.ToInt32(txtHoras.Text)
                        );

                    empleado.CalcularCobro();

                    //Displaying results
                    string result = $"Nombre: {empleado.Nombre}" +
                        $"\nAntigüedad: {empleado.Antiguo}" +
                        $"\nValor Hora: ${empleado.Salario}" +
                        $"\nTotal a Cobrar en Bruto: ${empleado.CobroBruto}" +
                        $"\nTotal descuentos: ${empleado.Deducciones}" +
                        $"\nTotal a cobrar en Neto: ${empleado.CobroNeto}";

                    MessageBox.Show(result, "Resultado", MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public class Empleado
        {
            private double salario;
            private string nombre;
            private int horas;
            private int antiguo;
            private double cobroBruto;
            private double deducciones;
            private double cobroNeto;

            public double Salario { get => salario; set => salario = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int Antiguo { get => antiguo; set => antiguo = value; }
            public double CobroBruto { get => cobroBruto; set => cobroBruto = value; }
            public double Deducciones { get => deducciones; set => deducciones = value; }
            public double CobroNeto { get => cobroNeto; set => cobroNeto = value; }
            public int Horas { get => horas; set => horas = value; }

            public Empleado(double salario, string nombre, int antiguo, int horas)
            {
                Salario = salario;
                Nombre = nombre;
                Antiguo = antiguo;
                Horas = horas;
            }

            public void CalcularCobro()
            {
                CobroBruto = (salario * horas) + (antiguo * 30);
                Deducciones = cobroBruto * 0.13;
                CobroNeto = cobroBruto - Deducciones;
            }

        }
    }
}
