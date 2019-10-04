using FinAPPcial.Api.Models;
using FinAPPcial.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController
    {
        public readonly ITransactionRepository transactions;

        public TransactionController(ITransactionRepository transaction)
        {
            this.transactions = transaction;
        }

        //[HttpGet]
        //public async Task<ActionResult<IQueryable<Transaction>>> GetTransactions()
        //{
        //    return Ok(transactions.Transactions);
        //}
    }
}
