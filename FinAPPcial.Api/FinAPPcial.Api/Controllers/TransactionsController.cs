using FinAPPcial.Api.Models;
using FinAPPcial.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Controllers
{
    [Route("api/transactions")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        public readonly ITransactionRepository transactions;

        public TransactionsController(ITransactionRepository transaction)
        {
            this.transactions = transaction;
        }

        [HttpGet]
        public async Task<ActionResult<IQueryable<Transaction>>> GetTransactions()
        {
            return Ok(transactions.Transactions);
        }

        [HttpPost("{transaction}")]
        public async Task<ActionResult> AddTransaction(Transaction transaction)
        {
            transactions.AddTransaction(transaction);
            return Ok();
        }
    }
}
