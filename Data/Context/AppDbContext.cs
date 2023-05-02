
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbContext : AppDbContextBase<AppDbContext>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Domain.Entities.Pedido> Pedido { get; set; }
        public virtual DbSet<Domain.Entities.Categoria> Categoria { get; set; }
        public virtual DbSet<Domain.Entities.Produto> Produto { get; set; }
        public virtual DbSet<Domain.Entities.Item_Pedido> Item_Pedido { get; set; }


    }
}
