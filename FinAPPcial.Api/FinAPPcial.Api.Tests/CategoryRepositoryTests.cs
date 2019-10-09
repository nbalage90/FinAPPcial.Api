using FinAPPcial.Api.Models;
using FinAPPcial.Api.Models.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinAPPcial.Api.Tests
{
    [TestClass]
    public class CategoryRepositoryTests
    {
        [TestMethod]
        public void GetCategories_Test()
        {
            // Arrange
            var repo = GetRepository();

            // Act
            var result = repo.Categories();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ICollection<Category>));
        }

        private ICategoryRepository GetRepository()
        {
            var repoMock = new Mock<ICategoryRepository>();
            repoMock.Setup(t => t.Categories())
                    .Returns(new List<Category> { new Category { CategoryId = 1, Name = "Food" },
                                                  new Category { CategoryId = 2, Name = "ED" } });

            return repoMock.Object;
        }
    }
}
