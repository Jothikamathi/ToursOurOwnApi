using System;
using System.Collections.Generic;

namespace ToursApi.Models;

public partial class Tour
{
    public int ToursId { get; set; }

    public string? Countries { get; set; }

    public int? Days { get; set; }

    public string? Price { get; set; }

    public string? Information { get; set; }

    public string? Interested { get; set; }

    public string? TourImage { get; set; }
}
