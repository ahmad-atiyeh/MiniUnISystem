using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniUnISystem
{

    public class StudentExam
    {
        public int Id { get; set; }
        public int Result { get; set; }

        public int StudentId { get; set; }
        public required Student Student { get; set; } // Added 'required' modifier

        public int ExamId { get; set; }
        public required Exam Exam { get; set; } // Added 'required' modifier
    }
}
