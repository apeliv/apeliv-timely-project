namespace Timely.Model
{
    public class Project
    {
        public Project(int id, string name, DateTime start, DateTime stop, TimeOnly duration)
        {
            Id= id;
            Name= name;
            Start= start;
            Stop= stop;
            Duration= duration;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public TimeOnly Duration { get; set; }

    }
}