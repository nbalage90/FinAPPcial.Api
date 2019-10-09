using FinAPPcial.Api.Models;
using FinAPPcial.Api.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
            var repo = GetRepository();

            // Act
            var result = repo.Transactions();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ICollection<Transaction>));
        }

        private ITransactionRepository GetRepository()
        {
            var repoMock = new Mock<ITransactionRepository>();
            repoMock.Setup(t => t.Transactions())
                    .Returns(new List<Transaction> { new Transaction { TransactionId = 1, Amount = 123 },
                                                     new Transaction { TransactionId = 2, Amount = 564 } });

            return repoMock.Object;
        }
    }
}
