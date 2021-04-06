using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEProject.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        [Required]
        public Course Course { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string FilePath { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public ICollection<Solution> Solutions { get; set; }

    }
}
