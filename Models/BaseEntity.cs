using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinder.Models
{
    public abstract class BaseEntity
    {

        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedById { get; set; } 
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedById { get; set; }



    }
}
