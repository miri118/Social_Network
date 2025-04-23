﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public enum Role
    {
        New,Veteran,Manager 
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string? ImageProfileUrl { get; set; }
        public Role Role { get; set; }
        public int CountMessages { get; set; }
    }
}
