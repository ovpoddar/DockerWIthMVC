using DockerWithMVC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWithMVC.Models
{
    public class ApplcaitionDBContext : DbContext
    {
        public ApplcaitionDBContext(DbContextOptions options) : base(options) 
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Person> People { get; set; }
    }
}
