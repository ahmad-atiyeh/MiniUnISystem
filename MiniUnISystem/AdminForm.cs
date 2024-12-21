using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniUnISystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public void CreateTeacherAccount(string name, string email, string password, string college)
        {
            using (var context = new UniContext())
            {
                var teacher = new Teacher { Name = name, Email = email, Password = password, College = college };
                context.Teachers.Add(teacher);
                context.SaveChanges();
            }
        }

        public void CreateStudentAccount(string name, string email, string password, string speciality)
        {
            using (var context = new UniContext())
            {
                var student = new Student { Name = name, Email = email, Password = password, Speciality = speciality };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void CreateCourse(string name, string description, string level)
        {
            using (var context = new UniContext())
            {
                var course = new Course { Name = name, Description = description, Level = level };
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public void UpdateCourse(int courseId, string name, string description, string level)
        {
            using (var context = new UniContext())
            {
                var course = context.Courses.Find(courseId);
                if (course != null)
                {
                    course.Name = name;
                    course.Description = description;
                    course.Level = level;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var context = new UniContext())
            {
                var course = context.Courses.Find(courseId);
                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();
                }
            }
        }

        public void AssignTeacherToCourse(int teacherId, int courseId)
        {
            using (var context = new UniContext())
            {
                var teacher = context.Teachers.Find(teacherId);
                var course = context.Courses.Find(courseId);

                if (teacher != null && course != null)
                {
                    course.Teachers.Add(teacher);
                    context.SaveChanges();
                }
            }
        }


        public void CreateExam(int courseId, string description, DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            using (var context = new UniContext())
            {
                var exam = new Exam { Description = description, Date = date, StartTime = startTime, EndTime = endTime };
                var course = context.Courses.Find(courseId);

                if (course != null)
                {
                    course.Exams.Add(exam);
                    context.SaveChanges();
                }
            }
        }

        public List<ExamRes> ViewExamResults(int examId)
        {
            using (var context = new UniContext())
            {
                return context.ExamResults.Where(er => er.ExamId == examId).ToList();
            }
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
