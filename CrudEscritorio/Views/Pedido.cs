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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            openDetallePedido();
            Cliente cliente = new Cliente();
            Pedidos pedidos = new Pedidos();
            
            pedidos.Fecha = DateTime.Parse(txtFecha.Text);
            pedidos.IdCliente = Convert.ToInt32(txtClientePedido.Text);
            pedidos.PrecioTotal = float.Parse(txtPrecioTotal.Text);

            
            try
            {
                if (PedidoController.guardar(pedidos))
                {
                    
                    cliente.LimpiarCampos();
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("Ya existe el Pedido");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void openDetallePedido()
        {
            DetallePedido detallePedido = new DetallePedido();
            detallePedido.ShowDialog();
        }
        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
