using System;
using System.Collections.Generic;

namespace SocialNetwork.Models;

public partial class Category
{
    public int Id { get; set; }

    public string NameCategory { get; set; } = null!;

    public virtual ICollection<Topic> Topics { get; } = new List<Topic>();
}
