using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiniUnISystem
{
    public class UniContext : DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMAD20-03DEVIC\\MSSQLSERVER01;Database=UniSystemDb;Trusted_Connection=True;TrustServerCertificate=True");

        }

    }
}
