using System;
using System.Collections.Generic;

namespace pruebaTecnica_v1.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public float? Precio { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaVencimiento { get; set; }
    }
}
