﻿namespace Timely.WebApi.Models
{
    public class ProjectRequest
    {
        public string ProjectName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Duration { get; set; }
    }
}
