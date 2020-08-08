using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbString")
        {

        }

        public DbSet<MyFirstTable> MyFirstTable { get; set; }
    }
}