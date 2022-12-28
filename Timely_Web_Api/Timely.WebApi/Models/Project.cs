using System;
using System.Collections.Generic;

namespace Timely.WebApi.Models;

public partial class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string Duration { get; set; }
}
