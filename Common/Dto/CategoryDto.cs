using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string NameCategory { get; set; }
        //public virtual ICollection<TopicDto> Topics { get; set; }//virtual- בגלל שלא חייבים לעשות לכל קטגוריה דיון
    }
}
