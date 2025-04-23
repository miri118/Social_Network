using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class MessageDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeSend { get; set; }
        public UserDto User { get; set; }
        public List<FeedbackDto> Likes { get; set; }
    }
}
