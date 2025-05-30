using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameCategory { get; set; }
        // ICollection
        public virtual List<Topic>? Topics { get; set; }//virtual- בגלל שלא חייבים לעשות לכל קטגוריה דיון
    }
}
