using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Models
{
    internal class Pedidos
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public float PrecioTotal  { get; set; }

        public ICollection<DetallePedidos> DetallePedidos { get; set; }

    }
}
