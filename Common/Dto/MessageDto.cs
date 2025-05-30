using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeSend { get; set; }
        public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public UserDto User { get; set; }
        public int TopicId { get; set; }

        //[ForeignKey("TopicId")]
        //public TopicDto Topic { get; set; }
        //public List<FeedbackDto>? Likes { get; set; }
    }
}
