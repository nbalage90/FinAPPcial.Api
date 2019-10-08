using FinAPPcial.Api.Models;
using FinAPPcial.Api.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FinAPPcial.Api.Tests
{
    [TestClass]
    public class TransactionRepositoryTests
    {
        [TestMethod]
        public void Transactions_Test()
        {
            // Arrange
            var repo = new TransactionRepository();

            // Act
            var result = repo.Transactions;

            // Assert
            Assert.IsInstanceOfType(result, typeof(ICollection<Transaction>));
        }

        [TestMethod]
        public void AddTreansaction_Test()
        {
            // Arrange
            var repo = new TransactionRepository();
            var transaction = new Transaction
            {
                TransactionId = 55,
                Amount = 3421
            };

            // Act
            var originalResult = repo.Transactions.Count();
            repo.AddTransaction(transaction);
            var newResult = repo.Transactions.Count();

            // Assert
            Assert.AreNotEqual(originalResult, newResult);
        }
    }
}
