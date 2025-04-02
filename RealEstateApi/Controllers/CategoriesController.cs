using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Models;

namespace RealEstateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category { Id = 0, Name = "Apartment", ImageUrl = "apartment.png" },
            new Category { Id = 1, Name = "Commercial", ImageUrl = "commercial.png" },
        };

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return categories;
        }

        [HttpPost]
        public void Post([FromBody] Category category)
        {
            categories.Add(category);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            categories[id] = category;
        }
    }
}
