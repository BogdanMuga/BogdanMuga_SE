using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEProject.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

    }
}
