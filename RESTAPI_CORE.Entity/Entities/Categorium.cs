using System;
using System.Collections.Generic;

namespace RESTAPI_CORE.Entity.Entities
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
