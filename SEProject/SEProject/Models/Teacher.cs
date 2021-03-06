using System.ComponentModel.DataAnnotations;

namespace SEProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
