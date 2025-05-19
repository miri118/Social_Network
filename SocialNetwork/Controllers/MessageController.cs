using Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IService<MessageDto> service;
        public MessageController(IService<MessageDto> service)
        {
            this.service = service;
        }
        // GET: api/<MessageController>
        [HttpGet]
        public List<MessageDto> Get()
        {
            return service.GetAll();
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        public MessageDto Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<MessageController>
        [HttpPost]
        public MessageDto Post([FromBody] MessageDto message)
        {
            return service.Add(message);
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MessageDto message)
        {
            service.Update(id, message);
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
