using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Models
{
    internal class Client
    {
        public int IdCliente { get; set; }
        
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public ICollection<Pedidos> Pedidos { get; set; }

        //public Client() {
        //    this.Nombre = string.Empty;            
        //    this.Telefono = string.Empty;   
        //    this.Direccion = string.Empty;
        //    this.Email = string.Empty;

        //}

    }


}
