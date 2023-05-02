using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class TransactionRepository: ITransactionRepository
    {

        internal readonly AppDbContext _context;

        public TransactionRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public void BeginTransaction()
        {
            this._context.Database.BeginTransaction();
        }

        public void RollbackTransaction()
        {
            this._context.Database.RollbackTransaction();
        }

        public async Task RollbackTransactionAsync()
        {
            await this._context.Database.RollbackTransactionAsync().ConfigureAwait(false);
        }

        public void CommitTransaction()
        {
            this._context.Database.CommitTransaction();
        }

        public async Task CommitTransactionAsync()
        {
            await this._context.Database.CommitTransactionAsync();
        }
    }
}
