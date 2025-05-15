using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
   public enum Imuge
    {
        Like,Dislike,Happy,Lought,Sad,Angry,Shock 
    }
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public Imuge Type { get; set; }//לשנות אולי לאימוגים בתור סוג
        public User User { get; set; }
    }
}
