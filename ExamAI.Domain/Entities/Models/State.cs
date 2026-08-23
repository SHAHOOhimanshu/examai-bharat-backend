using System;
using System.Collections.Generic;

namespace ExamAI.Infrastructure;

public partial class State
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
