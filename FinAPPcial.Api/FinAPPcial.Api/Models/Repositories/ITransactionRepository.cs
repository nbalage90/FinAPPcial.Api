﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models.Repositories
{
    public interface ITransactionRepository
    {
        ICollection<Transaction> Transactions { get; }

        void AddTransaction(Transaction transaction);
    }
}
