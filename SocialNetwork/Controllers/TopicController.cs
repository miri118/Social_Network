using Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly IService<TopicDto> service;
        // GET: api/<TopicController>
        [HttpGet]
        public List<TopicDto> Get()
        {
            return service.GetAll();
        }

        // GET api/<TopicController>/5
        [HttpGet("{id}")]
        public TopicDto Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<TopicController>
        [HttpPost]
        public TopicDto Post([FromBody] TopicDto topic)
        {
            return service.Add(topic);
        }

        // PUT api/<TopicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TopicDto topic)
        {
            service.Update(id, topic);
        }

        // DELETE api/<TopicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
