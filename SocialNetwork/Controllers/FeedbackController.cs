using Microsoft.AspNetCore.Mvc;
using SocialNetwork.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        SocialNetworkContext db = new SocialNetworkContext();

        // GET: api/<FeedbackController>
        [HttpGet]
        public List<Feedback> Get()
        {
            return db.Feedbacks.ToList();
        }

        // GET api/<FeedbackController>/5
        [HttpGet("{id}")]
        public Feedback Get(int id)
        {
            return db.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<FeedbackController>
        [HttpPost]
        public void Post(Feedback f)
        {
            db.Feedbacks.Add(f);
            db.SaveChanges();
        }

        // PUT api/<FeedbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<FeedbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Remove(Get(id));
            db.SaveChanges();
        }
    }
}
