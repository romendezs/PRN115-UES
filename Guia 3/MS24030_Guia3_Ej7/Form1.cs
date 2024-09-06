using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtHoras.Text == "")
                {
                    throw new Exception("El campo no puede estar vacio");
                }else if(Convert.ToDouble(txtHoras.Text) <= 0)
                {
                    throw new Exception("El valor debe ser mayor que cero");
                }

                Trabajador obrero = new Trabajador();
                obrero.Horas = Convert.ToDouble(txtHoras.Text);
                obrero.Salario();

                MessageBox.Show($"El salario del trabjador es de ${obrero.getSalario}");



            }catch(Exception ex){ 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Trabajador
    {
        private double horas;
        private double salario;

        public double Horas { get => horas; set => horas = value; }
        public double getSalario { get => salario; }

        public void Salario() {
            if (this.Horas<=40)
            {
                salario = this.Horas*16;
            }
            else{

                salario = (40 * 16) + ((this.Horas - 40) * 20);
            }
        }

        
    }
}
