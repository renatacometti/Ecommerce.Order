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
    [Table("ItemPedido")]
    public class Item_Pedido: BaseEntity
    {
        [Key]
        public override int Id { get; set; }

        [Required]
        public decimal Preco_Unitario { get; set; }

        [Required]
        public int Quantidade { get; set; }


        public int Id_Pedido { get; set; }

        [ForeignKey("Id_Pedido")]
        public virtual Pedido Pedido { get; set; }



        public int Id_Produto { get; set; }

        [ForeignKey("Id_Produto")]
        public Produto Produto { get; set; }

    }
}
