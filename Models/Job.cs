using System.ComponentModel.DataAnnotations;
using JobFinder.Enums;

namespace JobFinder.Models
{
    public class Job : BaseEntity
    {
        [Required, StringLength(100)]
        public string Title { get; set; } = null!;

        [Required, StringLength(300)]
        public string Description { get; set; } = null!; 
        public string? Location { get; set; } = null!; 
        public int WeeklyHours { get; set; }
        public string? SalaryRange { get; set; }
        public bool Homeoffice { get; set; }
        public JobType JobType { get; set; }

        public Guid CompanyId { get; set; }

        public Company Company { get; set; } = null!; // aqui vai guardar todas as informaçoes da Empresa
        // ao inves de procurar a empresa pelo CompanyId, vai já direto pela tabela company
        // estudar melhor essa propriedade de navegação

        public ICollection<JobTechnology> JobTechnologies { get; set; } = new List<JobTechnology>();

    }
}
