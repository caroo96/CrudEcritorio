using CrudEscritorio.Models;
using CrudEscritorio.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Controllers
{
    internal class ClienteController
    {

        //Metodo insertar datos o guardar
        public static bool guardar(Client c)
        {
            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "insert into Cliente values('" + c.Nombre + "','" + c.Telefono + "','" + c.Direccion + "','" + c.Email + "')";
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

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //Metodo para listar los clientes

        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "SELECT * FROM Cliente;"; //consulta
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);

                con.desconectar();
                return dt;

            }
            catch (Exception ex)
            {

                return null;
            }
        }

        //Metodo para consultar por id
        public static Client Consultar(string Id)
        {
            int IdCliente = Convert.ToInt32(Id);
            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "SELECT * FROM Cliente WHERE IdCliente = '" + IdCliente + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Client client = new Client();
                if (dr.Read())
                {

                    client.Nombre = dr["Nombre"].ToString();
                    client.Telefono = dr["Telefono"].ToString();
                    client.Direccion = dr["Direccion"].ToString();
                    client.Email = dr["Email"].ToString();
                    

                    con.desconectar();
                    return client;
                }
                else
                {
                    con.desconectar();
                    return null;
                }
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        //Metodo para actualizar
        public static bool Actualizar(Client c)
        {
            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                //string sql = "UPDATE Cliente SET nombre='" + c.Nombre + "',Telefono='" + c.Telefono + "',Direccion='" + c.Direccion + "' where IdCliente='" + c.IdCliente + "'";
                string sql = "UPDATE Cliente SET nombre='" + c.Nombre + "',Telefono='" + c.Telefono + "',Direccion='" + c.Direccion + "' where IdCliente='" + c.IdCliente + "'";

                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //Metodo para eliminar el Cliente
        public static bool Eliminar(string IdCliente)
        {
            try
            {
                Conexion con = new Conexion();  //instaciamos la conexion
                string sql = "DELETE FROM Cliente  where IdCliente='" + IdCliente + "'"; //hacemos la consulta
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }

            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }

}
