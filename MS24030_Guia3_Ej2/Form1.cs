using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!(txtNombre.Text == "") && !(txtNota.Text == ""))
            {
                //Creando un nuevo estudiante
                Estudiante estudiante = new Estudiante();

                //Pidiendo el nombre y validando
                try
                {
                    estudiante.Nombre = txtNombre.Text;
                    if (estudiante.Nombre.Length < 3)
                    {
                        throw new Exception("El nombre es muy corto");
                    }
                }
                catch (Exception eNombre)
                {
                    
                    MessageBox.Show(eNombre.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Pidiendo la nota y validando
                try{ 
                    estudiante.Nota = Convert.ToDouble(txtNota.Text);
                    if (estudiante.Nota < 0 || estudiante.Nota > 10)
                    {
                        throw new Exception("La nota debe estar entre 0 y 10");
                    }
                }
                catch(Exception eNota)
                {
                    MessageBox.Show(eNota.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            //Aqui podria ir un asyn, o una promesa xd_
                if (estudiante.Nota > 8)
                {
                    txtEstado.Text = $"{estudiante.Nombre} SI ha sido seleccionado";
                }
                else
                {
                    txtEstado.Text = $"{estudiante.Nombre} NO ha sido seleccionado";
                }

                txtNombre.Text = "";
                txtNota.Text = "";

            }
            else
            {
                MessageBox.Show("No pueden estar vacios los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }

    public class Estudiante
    {
        private string nombre;
        private double nota;

        public string Nombre {
            get { return nombre; } 
            set { nombre = value;}
        }
        public double Nota {
            get { return nota; }
            set
            { nota = value; }
        }
    }
}
