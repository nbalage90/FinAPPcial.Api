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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository repository)
        {
            this.categoryRepository = repository;
        }

        [HttpGet]
        public ICollection<Category> GetCategories()
        {
            return categoryRepository.Categories();
        }

        [HttpPost]
        public void AddCategory(Category category)
        {
            categoryRepository.AddCategory(category);
        }
    }
}
