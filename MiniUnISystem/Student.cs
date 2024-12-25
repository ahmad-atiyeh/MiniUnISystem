using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnISystem
{
    public class Student : User
    {
        public string Speciality { get; set; }

        public ICollection<StudentExam> StudentExams { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

}
