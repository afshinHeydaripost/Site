using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Claim
{
    public int Id { get; set; }

    public int MenuId { get; set; }

    public string ClaimValue { get; set; } = null!;

    public string Title { get; set; } = null!;
}
