using BaiThucHanh04.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh04.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students {get; set;}
         public DbSet<Employee> Employees {get; set;}
         public DbSet<Person> Persons {get; set;}

        

    
    }
}