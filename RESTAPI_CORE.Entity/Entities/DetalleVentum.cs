using System;
using System.Collections.Generic;

namespace RESTAPI_CORE.Entity.Entities
{
    public partial class DetalleVentum
    {
        public int IdDetalleVenta { get; set; }
        public int? IdVenta { get; set; }
        public int? IdProducto { get; set; }
        public string? MarcaProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public string? CategoriaProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }

        public virtual Ventum? IdVentaNavigation { get; set; }
    }
}
