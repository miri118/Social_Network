using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class Topic
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string Title { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; } = new List<Message>();
}
