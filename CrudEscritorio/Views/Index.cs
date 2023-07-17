using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEscritorio.Views
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            openPedido();
        }

        public void openPedido()
        {
            Pedido pedido = new Pedido();
            pedido.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openCliente();

        }

        public void openCliente()
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            openProducto();

        }

        public void openProducto()
        {
            Producto producto = new Producto();
            producto.ShowDialog();
        }
    }
}
