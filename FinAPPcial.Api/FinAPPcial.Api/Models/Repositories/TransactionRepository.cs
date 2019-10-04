using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private IQueryable<Transaction> transactions;

        public TransactionRepository()
        {
            this.transactions = new List<Transaction>().AsQueryable();
        }

        public IQueryable<Transaction> Transactions =>
            this.transactions;

        public void AddTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
