using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public abstract class AppDbContextBase<T> : DbContext where T : DbContext
    {
        public AppDbContextBase(DbContextOptions<T> options) : base(options) { }
    }
}
