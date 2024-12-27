using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnISystem
{
    public class Exam
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
 
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; } 
        public IList<StudentExam> StudentExams { get; set; } = new List<StudentExam>();
        public IList<Question> Questions { get; set; } = new List<Question>();

    }
}
