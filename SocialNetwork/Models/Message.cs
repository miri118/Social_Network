using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class Message
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime TimeSend { get; set; }

    public int UserId { get; set; }

    public int? TopicId { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

    public virtual Topic? Topic { get; set; }

    public virtual User User { get; set; } = null!;
}
