using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public int CountMessages { get; set; }

    public string? ImageProfileUrl { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

    public virtual ICollection<Message> Messages { get; } = new List<Message>();
}
