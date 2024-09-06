using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2_MS24030_Ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!(dgvEstudiantes.Rows.Count > 10))
            {
                if (!(txtNombre.Text == "") && (Convert.ToDouble(txtNota.Text) > 0) && (Convert.ToDouble(txtNota.Text) <= 10))
                {

                    Estudiante estudiante = new Estudiante();

                    //Constructor
                    estudiante.Nombre = txtNombre.Text;
                    estudiante.Nota = Convert.ToDouble(txtNota.Text);

                    //Salida de datos
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvEstudiantes);

                    fila.Cells[0].Value = estudiante.Nombre;
                    fila.Cells[1].Value = Convert.ToString(estudiante.Nota);

                    dgvEstudiantes.Rows.Add(fila);
                }
                else
                {
                    MessageBox.Show("No puedes dejar los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnAgregar.Enabled = false;
                MessageBox.Show("Ya hay 10 estudiantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
