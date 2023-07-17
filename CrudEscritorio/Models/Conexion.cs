using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Models
{
    public class Conexion
    {
        SqlConnection con;

        // contructor para conexion
        public Conexion()
        {
            //cadena de conexion
            con = new SqlConnection("server=DESKTOP-KQUPM3K\\MSSQLSERVER01; database=CrudEscritorio; integrated security = true"); ;  // cadena de conexion
        }

        // metodo para conectar a la bd
        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {

                throw;
            }

        }
        //metodo para desconectar
        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }

        }
    }
}