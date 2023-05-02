using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Categoria")]
    public class Categoria: BaseEntity
    {
        [Key]
        [Column("Id")]
        public override int Id { get; set; }

        [Required]
        [MaxLength(200)]    
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        
    }
}
