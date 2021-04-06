using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEProject.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        
        [Required]
        public ApplicationUser Teacher { get; set; }

        public IEnumerable<StudentCourse> StudentsEnrolled { get; set; }

    }
}
