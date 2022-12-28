using System;
using System.Collections.Generic;

namespace RESTAPI_CORE.Entity.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            HistorialRefreshTokens = new HashSet<HistorialRefreshToken>();
            Venta = new HashSet<Ventum>();
        }

        public int IdUsuario { get; set; }
        public string? Nombre { get; set; }
        public string Correo { get; set; } = null!;
        public string? Telefono { get; set; }
        public int? IdRol { get; set; }
        public string? UrlFoto { get; set; }
        public string? NombreFoto { get; set; }
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public bool? EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Rol? IdRolNavigation { get; set; }
        public virtual ICollection<HistorialRefreshToken> HistorialRefreshTokens { get; set; }
        public virtual ICollection<Ventum> Venta { get; set; }
    }
}
