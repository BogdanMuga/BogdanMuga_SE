using System.ComponentModel.DataAnnotations;

namespace SEProject.Models
{
    public class Solution
    {
        public int AssignmentId { get; set; }
        
        public int StudentId { get; set; }
        
        public Assignment Assignment { get; set; }

        public Student Student { get; set; }
        
        [MaxLength(150)]
        public string FilePath { get; set; }
        
        public decimal Grade { get; set; }
        
        [MaxLength(300)]
        public string TeacherComment { get; set; }
    }
}
