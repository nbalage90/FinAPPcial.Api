using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICollection<Category> categories;

        public CategoryRepository()
        {
            categories = new List<Category>
            { 
                new Category { CategoryId = 1, Name = "Food"},
                new Category { CategoryId = 2, Name = "Electronic devices" }
            };
        }

        public ICollection<Category> Categories()
        {
            return categories;
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }
    }
}
