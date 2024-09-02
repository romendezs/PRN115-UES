using System.Security.Cryptography.X509Certificates;

namespace PRN115_Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMarca.Text =="" || txtCantidad.Text == "" || txtNombreCliente.Text == "")
                {
                    throw new Exception("Los campos no pueden estar vacios");
                }

                Venta facturaVenta = new Venta();

                facturaVenta.Cliente = txtNombreCliente.Text;
                facturaVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
                facturaVenta.Marca = Convert.ToInt32(txtMarca.Text);

                lblFactura.Text = facturaVenta.Factura();

                txtMarca.Text = ""; txtCantidad.Text = ""; txtNombreCliente.Text = "";




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
