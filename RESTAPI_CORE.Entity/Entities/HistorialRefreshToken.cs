using System;
using System.Collections.Generic;

namespace RESTAPI_CORE.Entity.Entities
{
    public partial class HistorialRefreshToken
    {
        public int IdHistorialToken { get; set; }
        public int? IdUsuario { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public bool? EsActivo { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
