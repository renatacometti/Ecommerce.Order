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
    [Table("Produto")]
    public class Produto: BaseEntity
    {
        [Key]
        public override int Id { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descricao { get; set; }

        [Required]
        public decimal Preco_Custo { get; set; }

        [Required]
        public decimal Preco_Venda { get; set; }

        [Required]
        public int Quantidade_Estoque { get; set; }

        public int Id_Categoria { get; set; }

        [ForeignKey("Id_Categoria")]
        public Categoria Categoria { get; set; }

        public ICollection<Item_Pedido> Produtos { get; set; }

        
    }
}
