using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private ICollection<Transaction> transactions;

        public TransactionRepository()
        {
            this.transactions = new List<Transaction>
            {
                new Transaction { TransactionId = 1, Amount = 1500 },
                new Transaction { TransactionId = 2, Amount = 12500 }
            };
        }

        public ICollection<Transaction> Transactions() =>
            this.transactions;

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }
    }
}
