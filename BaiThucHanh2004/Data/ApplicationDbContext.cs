using BaiThucHanh2004.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2004.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
     
         public DbSet<Faculty> Facultys {get; set;}
     
         public DbSet<BaiThucHanh2004.Models.Student> Student { get; set; } = default!;
       

        

    
    }
}