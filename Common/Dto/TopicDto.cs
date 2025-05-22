using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class TopicDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryDto Category { get; set; }
        public string Title { get; set; }
        public List<MessageDto> ListMessages { get; set; }
        //public Message LastMessage { get; set; }
        //public int NumResponses { get; set; }
    }
}
