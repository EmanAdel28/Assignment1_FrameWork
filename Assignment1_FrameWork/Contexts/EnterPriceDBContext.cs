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
    }
}
