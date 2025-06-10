using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class User : BaseEntity
    {
        [Required (ErrorMessage = "Campo não preenchido")]
        [StringLength(30)]
        public string FirstName { get; set; } = null!;

        [StringLength(30)]
        public string? LastName { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!; // BCrypt.Net Lembrar de usar isso

        public string? LinkedinURL { get; set; }

        [StringLength(20)]
        public string? PhoneNumber { get; set; }



    }
}
