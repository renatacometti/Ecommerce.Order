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
    [Table("Pedido")]
    public class Pedido: BaseEntity
    {

        [Key]
        public override int Id { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public DateTime Data { get; set; }
     
        public int Forma_Pagamento { get; set; }

        public ICollection<Item_Pedido> Pedidos { get; set; }

        
    }
}