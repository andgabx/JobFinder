namespace JobFinder.Models
{
    public class JobTechnology
    {
        public Guid JobId { get; set; }
        public Job Job { get; set; } = null!;
        public Guid TechnologyId { get; set; }
        public Technology Technology { get; set; } = null!;

    }
}
