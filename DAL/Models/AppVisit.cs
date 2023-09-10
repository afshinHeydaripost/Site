using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class AppVisit
{
    public int Id { get; set; }

    public int AppTokenId { get; set; }

    public DateTime UpdateDate { get; set; }
}
