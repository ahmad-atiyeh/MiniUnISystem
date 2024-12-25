using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnISystem
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public int TeacherId { get; set; } // Foreign key
        public Teacher Teacher { get; set; } // Navigation property
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
