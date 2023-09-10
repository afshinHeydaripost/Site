using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NewsCategory
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUserId { get; set; }

    public string? Keywords { get; set; }

    public string? Description { get; set; }

    public bool Disabled { get; set; }
}
