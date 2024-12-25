using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace MiniUnISystem
{
    public partial class AdminForm : Form
    {
        UniContext context = new UniContext();

        public AdminForm()
        {
            InitializeComponent();
        }

        public void CreateStudentAccount(string name, string email, string password, string speciality)
        {
            var student = new Student
            {
                Name = name,
                Email = email,
                Password = password,
                Speciality = speciality
            };
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void CreateCourse(string name, string description, int teacherId)
        {
            var course = new Course
            {
                Name = name,
                Description = description,
                TeacherId = teacherId
            };
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void UpdateCourse(int courseId, string name, string description, int teacherId)
        {
            var course = context.Courses.Find(courseId);
            if (course != null)
            {
                course.Name = name;
                course.Description = description;
                course.TeacherId = teacherId;
                context.SaveChanges();
            }
        }

        public void DeleteCourse(int courseId)
        {
            var course = context.Courses.Find(courseId);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }

        public void AssignTeacherToCourse(int courseId, int teacherId)
        {
            var course = context.Courses.Find(courseId);
            if (course != null)
            {
                course.TeacherId = teacherId;
                context.SaveChanges();
            }
        }

        public void CreateExam(int courseId, string description, DateTime date)
        {
            var exam = new Exam
            {
                CourseId = courseId,
                Description = description,
                Date = date
            };
            context.Exams.Add(exam);
            context.SaveChanges();
        }

        public List<StudentExam> ViewExamResults(int examId)
        {
            return context.StudentExams
                .Where(se => se.ExamId == examId)
                .Include(se => se.Student)
                .ToList();
        }

        public Teacher? LogIn(string email, string password)
        {
            return context.Teachers
                .FirstOrDefault(t => t.Email == email && t.Password == password);
        }

        public List<Course> ViewAssignedCourses(int teacherId)
        {
            return context.Courses
                   .Where(c => c.TeacherId == teacherId)
                   .ToList();
        }

        public List<Exam> ViewExams(int courseId)
        {
            return context.Exams
                .Where(e => e.CourseId == courseId)
                .ToList();
        }

        public void EnrollInCourse(int studentId, int courseId)
        {
            var enrollment = new StudentCourse
            {
                StudentId = studentId,
                CourseId = courseId
            };
            context.StudentCourses.Add(enrollment);
            context.SaveChanges();
        }

        public void SubmitExam(int studentId, int examId, int result)
        {
            var student = context.Students.Find(studentId);
            var exam = context.Exams.Find(examId);

            if (student != null && exam != null)
            {
                var studentExam = new StudentExam
                {
                    StudentId = studentId,
                    Student = student, // Set the required Student member
                    ExamId = examId,
                    Exam = exam, // Set the required Exam member
                    Result = result
                };
                context.StudentExams.Add(studentExam);
                context.SaveChanges();
            }
        }

        public void AddQuestionToExam(int examId, string text, string choice1, string choice2, string choice3, string choice4, string answer)
        {
            var question = new Question
            {
                ExamId = examId,
                Text = text,
                Choice1 = choice1,
                Choice2 = choice2,
                Choice3 = choice3,
                Choice4 = choice4,
                Answer = answer
            };
            context.Questions.Add(question);
            context.SaveChanges();
        }

        private void teacherRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void accountsRB_CheckedChanged(object sender, EventArgs e)
        {
            AccountsGroupBox.Visible = true;
            courseGroupBox.Visible = false;
            AssignGroupBox.Visible = false;
        }
    }
}
