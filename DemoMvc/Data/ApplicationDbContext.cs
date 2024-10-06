using Microsoft.EntityFrameworkCore;
using DemoMvc.Models.Entities;
using DemoMvc.Models;
using DemoMVC.Models.Entities;

namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet <Person> Person {get;set;}

        public DbSet <Student> Student {get;set;}
        public DbSet <Employee> Employee {get;set;}
    }
    }




