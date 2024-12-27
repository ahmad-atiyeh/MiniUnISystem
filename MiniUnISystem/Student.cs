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

        public IList<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
        public IList<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }

}
