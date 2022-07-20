using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    [Table("CasoDetalle")]
    public partial class CasoDetalle
    {
        [Key]
        [Column("detalleId")]
        public int DetalleId { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string NombreDetalle { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("casoId", TypeName = "int")]
        public int? CasoId { get; set; }
        [Column("servicioId", TypeName = "int")]
        public int? ServicioId { get; set; }

        [ForeignKey("detalleId")]
        [InverseProperty("CasoDetalles")]
        public virtual Caso CasoDetalleNavigation { get; set; } = null!;

    }
}
