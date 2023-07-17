using CrudEscritorio.Models;
using CrudEscritorio.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Controllers
{
    internal class PedidoController
    {
        //Metodo insertar datos o guardar
        public static bool guardar(Pedidos p)
        {
            var fecha = p.Fecha.Year + "-" + p.Fecha.Month + "-" + p.Fecha.Day;


            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "insert into Pedido values('" + fecha + "'," + p.IdCliente + "," + p.PrecioTotal + ")";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cant = comando.ExecuteNonQuery();
                con.desconectar();
                                if (cant == 1)
                {

                    return true;
                }
                else
                {

                    return false;
                }

                int idPedido = Convert.ToInt32(comando.ExecuteScalar());
                p.IdPedido = idPedido;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}

