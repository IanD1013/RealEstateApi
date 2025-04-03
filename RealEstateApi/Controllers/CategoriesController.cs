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
        public IActionResult Get()
        {
            //return StatusCode(StatusCodes.Status200OK);
            return Ok(_dbContext.Categories);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category categoryObj)
        {
            var category = _dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound("No record found against this Id: " + id);
            }
            else 
            { 
                category.Name = categoryObj.Name;
                category.ImageUrl = categoryObj.ImageUrl;
                _dbContext.SaveChanges();
                return Ok("Record updated successfully");
            }
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound("No record found against this Id: " + id);
            }
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();
            return Ok("Record deleted");
        }
    }
}
