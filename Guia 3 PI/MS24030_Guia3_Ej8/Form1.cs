using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS24030_Guia3_Ej8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            //Creating new Dado and throwing dices
            Dado tiro = new Dado();
            tiro.tirarDados();

            //Displaying results in the text boxes
            txtDado1.Text = Convert.ToString(tiro.Dado1);
            txtDado2.Text = Convert.ToString(tiro.Dado2);
            txtDado3.Text = Convert.ToString(tiro.Dado3);

            //Calculating results
            lblResults.Text = tiro.Resultado();

            //Handling buttons
            btnTirar.Enabled = false;
            btnLimpiar.Enabled = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDado1.Text = "";
            txtDado2.Text = "";
            txtDado3.Text = "";
            lblResults.Text = "";

            //Buttons
            btnTirar.Enabled = true;
            btnLimpiar.Enabled = false;

        }

    }

    public class Dado
    {
        private int dado1;
        private int dado2;
        private int dado3;


        public int Dado1 { get => dado1;}
        public int Dado2 { get => dado2;}
        public int Dado3 { get => dado3;}

        public void tirarDados()
        {
            Random random = new Random();
            dado1 = random.Next(1, 7);
            dado2 = random.Next(1, 7);
            dado3 = random.Next(1, 7);
        }

        public string Resultado()
        {
            string mensaje;
            if(dado1==6 && dado2==6 && dado3 == 6)
            {
                mensaje = "¡¡¡ Ganó 1,000,000 !!!";
            } else if ((dado1==6 && dado2==6 )|| (dado1 == 6 && dado3 == 6) || (dado2 == 6 && dado3 == 6))
            {
                mensaje = "¡Ganó TV!”";
            }else if(dado1 == 6 || dado2 == 6 || dado3 == 6)
            {
                mensaje = "Continue intentando";
            }
            else
            {
                mensaje = "Pierde todo";
            }
            return mensaje;
        }

    }
}
