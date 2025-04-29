using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public bool Type { get; set; }

    public int UserId { get; set; }

    public int? MessageId { get; set; }

    public virtual Message? Message { get; set; }

    public virtual User User { get; set; } = null!;
}
