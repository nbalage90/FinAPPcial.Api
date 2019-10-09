using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models.Repositories
{
    public interface ICategoryRepository
    {
        ICollection<Category> Categories();
        void AddCategory(Category category);
    }
}
