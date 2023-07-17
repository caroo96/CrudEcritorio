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
    internal class DetallePedidoController
    {

        //Metodo insertar datos o guardar
        public static bool guardar(DetallePedidos d)
        {
            int idPedido = d.IdPedido;

            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "insert into DetallePedido values('" + idPedido + "'," + d.IdProducto + "," + d.Cantidad + ")";
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

                int idDetalle = Convert.ToInt32(comando.ExecuteScalar());
                d.IdDetallePedido = idDetalle;

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
