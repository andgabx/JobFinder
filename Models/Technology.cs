using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class Technology : BaseEntity
    {
        [Required, MaxLength(30)]
       public string Name { get; set; } = null!;

        public ICollection<JobTechnology> JobTechnologies { get; set; } = new List<JobTechnology>();

    }
}
