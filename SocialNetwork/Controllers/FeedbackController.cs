﻿using Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialNetwork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IService<FeedbackDto> service;
        public FeedbackController(IService<FeedbackDto> service)
        {
            this.service = service;
        }
        // GET: api/<FeedbackController>
        [HttpGet]
        public List<FeedbackDto> Get()
        {
            return service.GetAll();
        }

        // GET api/<FeedbackController>/5
        [HttpGet("{id}")]
        public FeedbackDto Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<FeedbackController>
        [HttpPost]
        public FeedbackDto Post([FromBody] FeedbackDto feedback)
        {
            return service.Add(feedback);
        }

        // PUT api/<FeedbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FeedbackDto feedback)
        {
            service.Update(id, feedback);
        }

        // DELETE api/<FeedbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
