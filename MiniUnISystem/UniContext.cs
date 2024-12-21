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
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamRes> ExamResults { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=AHMAD20-03DEVIC\\MSSQLSERVER01;Database=UniSystemDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships, keys, and constraints here

            modelBuilder.Entity<Student>();
            modelBuilder.Entity<Teacher>();
            modelBuilder.Entity<Admin>();

            modelBuilder.Entity<Student>()
                .Property(s => s.Id)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Email)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.Password)
                .IsRequired();

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Id)
                .IsRequired();

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Name)
                .IsRequired();

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Email)
                .IsRequired();

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Password)
                .IsRequired();

            modelBuilder.Entity<Admin>()
                .Property(a => a.Id)
                .IsRequired();

            modelBuilder.Entity<Admin>()
                .Property(a => a.Name)
                .IsRequired();

            modelBuilder.Entity<Admin>()
                .Property(a => a.Email)
                .IsRequired();

            modelBuilder.Entity<Admin>()
                .Property(a => a.Password)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(e => e.Description)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(e => e.Date)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(e => e.StartTime)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .Property(e => e.EndTime)
                .IsRequired();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamResults)
                .WithOne(er => er.Exam)
                .HasForeignKey(er => er.ExamId);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Questions)
                .WithOne(q => q.Exam)
                .HasForeignKey(q => q.ExamId);

            modelBuilder.Entity<ExamRes>()
                .HasOne(er => er.Student)
                .WithMany()
                .HasForeignKey(er => er.StudentId);

            modelBuilder.Entity<ExamRes>()
                .HasOne(er => er.Exam)
                .WithMany()
                .HasForeignKey(er => er.ExamId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Teachers)
                .WithMany(t => t.Courses);
        }


    }
}
