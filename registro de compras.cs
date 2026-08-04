using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registros_de_compras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double precio = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Laptop");
            cboProductos.Items.Add("mause");
            cboProductos.Items.Add("teclado");
            cboProductos.Items.Add("monitor");
            cboProductos.Items.Add("memoria USB");
            cboProductos.Items.Add("disco SSD");
            cboProductos.Items.Add("Audiculares");
            cboProductos.Items.Add("WebCam");


        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboProductos.Text)
            {
                case "Laptop":
                    precio = 3500;
                    break;

                case "mause":
                    precio = 800;
                    break;

                case "teclado":
                    precio = 1200;
                    break;

                case "monitor":
                    precio = 5500;
                    break;

                case "memoria USB":
                    precio = 500;
                    break;

                case "disco SSD":
                    precio = 2500;
                    break;

                case "Audiculares":
                    precio = 1500;
                    break;

                case "WebCam":
                    precio = 2200;
                    break;
            }

           
        }


        private void CalcularTotal()
        {
            int cantidad = int.Parse(Cantidad.Text);

            double total = precio * cantidad;

            lblTotal.Text = total.ToString();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularTotal();
                   

            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string producto = cboProductos.Text;
            int cantidad = int.Parse(Cantidad.Text);

            double total = precio * cantidad;

            string pago = "";

            if (rbnEfectivo.Checked)
            {
                pago = "efectivo";
            }
            else
            {
                pago = "trajeta";
            }
            lstClientes.Items.Add
                (nombre + " / "
                + telefono + " / "
                + correo + " / "
                + producto + " / "
                + cantidad + " / "
                + total + " / "
                + pago);

        }

        private void rbnTrajeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
