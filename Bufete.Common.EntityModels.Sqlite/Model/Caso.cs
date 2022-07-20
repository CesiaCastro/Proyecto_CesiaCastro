using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    [Table("Caso")]
    public partial class Caso
    {
        
        public Caso()
        {
            CasoDetalles = new HashSet<CasoDetalle>();
        }

        [Key]
        [Column("casosId")]
        public int? CasosId { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string CasoNombre { get; set; } = null!;
        [Column("clienteId", TypeName = "int")]
        public string? ClienteId { get; set; }
        public string? TipoCaso { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string? Departamento { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string? Estado { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("Casos")]
        public virtual Cliente? Cliente { get; set; }
        [InverseProperty("CasoDetalleNavigation")]
        public virtual ICollection<CasoDetalle> CasoDetalles { get; set; }
    }
}
