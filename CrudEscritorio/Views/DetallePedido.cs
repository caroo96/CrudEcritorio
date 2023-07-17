using CrudEscritorio.Controllers;
using CrudEscritorio.Models;
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
    public partial class DetallePedido : Form
    {
        public DetallePedido()
        {
            InitializeComponent();
        }

        private void txtAgregarProducto_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Pedidos pedidos = new Pedidos();
            DetallePedidos detallePedidos = new DetallePedidos();

            detallePedidos.IdPedido = pedidos.IdPedido; ; // Asignar el ID del pedido correspondiente al detalle del pedido
            detallePedidos.IdProducto = Convert.ToInt32(txtIdProductoDetalle.Text);
            detallePedidos.Cantidad = float.Parse(txtCantidad.Text);



            try
            {
                if (DetallePedidoController.guardar(detallePedidos))
                {

                    cliente.LimpiarCampos();
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("Ya existe el Detalle Pedido");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
