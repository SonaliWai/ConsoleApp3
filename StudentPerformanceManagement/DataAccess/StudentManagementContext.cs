using Microsoft.EntityFrameworkCore;
using StudentPerformanceManagement.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.DataAccess
{
    public class StudentManagementContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        //public DbSet<BrandProductInfoResult> brandInfo { get; set; }
        public DbSet<Marks> marks { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK12;Initial Catalog=StudentManagement;Integrated Security=True");
        }

    }
}
