using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Casos = new HashSet<Caso>();
        }

        [Key]
        
        
        [Column(TypeName = "ntext(40)")]
        [RegularExpression("A-Z{5}")]
        public string? ClientesId { get; set; } = null;
        [Required]
        
        [Column(TypeName = "nvarchar(15)")]
        public string Nombre { get; set; } = null!;
       
        [Column(TypeName = "nvarchar(15)")]
        public string? Edad { get; set; }
       
        [Column(TypeName = "nvarchar(40)")]
        public string? Telefono { get; set; }
       
        [Column(TypeName = "nvarchar(40)")]
        public string? Correo { get; set; }
      
        [Column(TypeName = "datetime")]
        public string? Direccion { get; set; }
        public DateTime? FechaRegistro { get; set; }

        [InverseProperty("Cliente")]
        public virtual ICollection<Caso> Casos { get; set; }
    }
}
