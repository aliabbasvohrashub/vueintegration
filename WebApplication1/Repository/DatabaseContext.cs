using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class DatabaseContext : DbContext
    {
        //public DatabaseContext() : base("DbString")
        //{

        //}
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<MyFirstTable> MyFirstTable { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}