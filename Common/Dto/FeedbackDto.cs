using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class FeedbackDto
    {
        [Key]
        public int Id { get; set; }
        public bool Type { get; set; }//לשנות אולי לאימוגים בתור סוג
        public UserDto User { get; set; }
    }
}
