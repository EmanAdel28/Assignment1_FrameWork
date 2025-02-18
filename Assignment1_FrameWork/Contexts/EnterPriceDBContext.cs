using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_FrameWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_FrameWork.Contexts
{
    internal class EnterPriceDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITIDatabase ; Trusted_Connection = true ;TrustServerCertificate =true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Primary Key Configuration
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            base.OnModelCreating(modelBuilder);
        }
    }
}
