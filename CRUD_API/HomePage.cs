using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_API
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageProveedor pageproveedor = new PageProveedor();
            pageproveedor.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            PageCliente pagecliente = new PageCliente();
            pagecliente.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            PageCompra comprapage = new PageCompra();
            comprapage.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ProductoPage productopage = new ProductoPage();
            productopage.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            VentaPage ventapage = new VentaPage();
            ventapage.Show();
        }
    }
}
