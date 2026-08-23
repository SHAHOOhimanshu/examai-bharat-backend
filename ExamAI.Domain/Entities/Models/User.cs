using System;
using System.Collections.Generic;

namespace ExamAI.Infrastructure;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int StateId { get; set; }

    public int CityId { get; set; }

    public bool TermsAccepted { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual State State { get; set; } = null!;
}
