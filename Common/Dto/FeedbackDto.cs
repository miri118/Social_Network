using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public enum Imoje
    {
        Like, Dislike, Happy, Lought, Sad, Angry, Shock
    }
    public class FeedbackDto
    {
        public int Id { get; set; }
        public Imoje Type { get; set; }
        public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public UserDto User { get; set; }
        public int MessageId { get; set; }

        //[ForeignKey("MessageId")]
        //public MessageDto Message { get; set; }
    }
}
