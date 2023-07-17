using CrudEscritorio.Controllers;
using CrudEscritorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudEscritorio.Views
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCerrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCiente_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Nombre = txtNombre.Text;
            client.Telefono = txtTelefono.Text;
            client.Direccion = txtDireccion.Text;
            client.Email = txtCorreo.Text;
            //bool respuesta = ClienteController.guardar(client);

            try
            {
                if (ClienteController.guardar(client))
                {
                    LimpiarCampos();
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("Ya existe el usuario");
                }

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }


        //Metodo para limpiar los campos
        public void LimpiarCampos()
        {
            txtNombre.Text= string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCorreo.Text = string.Empty;

        }

        //Metodo para consultar

        bool consultado = false;
        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text.Trim() == "")  //validacion de campo vacio
            {

                MessageBox.Show("Para consultar debe igresar el Id Cliente");
            }
            else
            {
                Client client = ClienteController.Consultar(txtIdCliente.Text.Trim()); //Instanciamos la clase  y llamamos el metodo consultar

                if (client == null)
                {
                    MessageBox.Show("No existe el producto con referencia " + txtIdCliente.Text);
                    LimpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtNombre.Text = client.Nombre;  //aqui actualizamos los campos de texto con las variables de los atributos
                    txtTelefono.Text = client.Telefono;
                    txtDireccion.Text = client.Direccion;
                    txtCorreo.Text = client.Email;


                    consultado = true;
                }
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            LlenarGridClientes();
        }

        //Metodo para mostrar los datos en el grid
        public void LlenarGridClientes()
        {
            DataTable datos = ClienteController.listar();

            if (datos == null)
            {
                MessageBox.Show("No se logro acceder a los datos");
            }
            else
            {
                GdListaClientes.DataSource = datos.DefaultView;
            }
        }

        //Boton Editar
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
           
             if (consultado == false)
            {

                MessageBox.Show("Debes consultar primero por Id");
            }
            else if (txtIdCliente.Text.Trim() == "")  //validacion de campo vacio
            {

                MessageBox.Show("Debe igresar un Id Vaido");
            }
            else if (txtNombre.Text.Trim().Length < 2)  //validacion de tama�o de texto
            {
                MessageBox.Show("Debe ingresar un nombre mas largo");
            }
            else
            {
                try
                {
                    Client client = new Client(); //instanciamos la clase cliente

                    client.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    client.Nombre = txtNombre.Text.Trim().ToUpper();
                    client.Telefono = txtTelefono.Text.Trim().ToUpper();
                    client.Direccion = txtDireccion.Text.Trim().ToUpper();
                    client.Email = txtCorreo.Text.Trim().ToUpper();

                    if (ClienteController.Actualizar(client))
                    {
                        LlenarGridClientes(); // llamamos el metodo
                        LimpiarCampos();
                        MessageBox.Show("El cliente se actualizo correctamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo el cliente");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Boton Eliminar
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            
            if (consultado == false)
            {

                MessageBox.Show("Debe consultar primero el cliente");
            }
            else if (txtIdCliente.Text.Trim() == "")  //validacion de campo vacio 
            {

                MessageBox.Show("Debe igresar un Id valido");
            }
            else if (DialogResult.Yes == MessageBox.Show(null, "¿Estás seguro en eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo))
            {

                try
                {

                    if (ClienteController.Eliminar(txtIdCliente.Text.Trim()))
                    {
                        LlenarGridClientes(); // llamamos el metodo
                        LimpiarCampos();
                        MessageBox.Show("Registro eliminado correctamente");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó el cliente");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
