using Microsoft.AspNetCore.Mvc;
using RealEstateApi.Data;
using RealEstateApi.Models;

namespace RealEstateApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ApiDbContext _dbContext = new ApiDbContext();

        // GET: api/<CategoriesController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _dbContext.Categories;
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category categoryObj)
        {
            var category = _dbContext.Categories.Find(id);
            category.Name = categoryObj.Name;
            category.ImageUrl = categoryObj.ImageUrl;
            _dbContext.SaveChanges();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var category = _dbContext.Categories.Find(id);
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
        }
    }
}
