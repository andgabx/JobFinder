using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class Company : BaseEntity
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Description { get; set; } = null!;
 
        public string? WebsiteURL { get; set; }

        [Required]
        public int EmployeesNumber { get; set; }

        public ICollection<Job> Jobs { get; set; } = new List<Job>();
        // ler sobre o ICollection, é uma interface mais genérica do Entity, e depois 
        // inicializamos uma lista vazia de varios Job


    }
}
