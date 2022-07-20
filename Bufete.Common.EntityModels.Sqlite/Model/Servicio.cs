using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    [Table("Servicios ")]
    public partial class Servicio
    {
       

        [Key]
        [Column("servicioId")]
        public int? ServicioId { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string ServicioNombre { get; set; } = null!;
        [Column(TypeName = "nvarchar(40)")]
        public string? Descripcion { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string? TipoServicio { get; set; }

        
    }
}
