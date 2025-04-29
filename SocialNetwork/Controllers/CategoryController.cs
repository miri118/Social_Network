using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using SocialNetwork.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        SocialNetworkContext db = new SocialNetworkContext();

        // GET: api/<CategoryController>
        [HttpGet]
        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(x => x.Id == id);
        }
        [HttpGet("getBy/{name}")]
        public Category GetCategoryByName(string name)
        {
            return db.Categories.FirstOrDefault(x => x.NameCategory == name);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Categories.Remove(Get(id));
            db.SaveChanges();
        }
    }
}
