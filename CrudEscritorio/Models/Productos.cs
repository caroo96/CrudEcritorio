﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEscritorio.Models
{
    internal class Productos
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
       
        public ICollection<DetallePedidos> DetallePedidos { get; set; }

    }
}
