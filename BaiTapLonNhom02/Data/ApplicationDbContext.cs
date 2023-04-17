using BaiTapLonNhom02.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiTapLonNhom02.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
         public DbSet<BaiTapLonNhom02.Models.SinhVien> SinhVien { get; set; } = default!;

        public DbSet<BaiTapLonNhom02.Models.Nhom> Nhom { get; set; } = default!;

        public DbSet<BaiTapLonNhom02.Models.Cathi> Cathi { get; set; } = default!;

        public DbSet<BaiTapLonNhom02.Models.DangNhap> DangNhap { get; set; } = default!;
       

        

    
    }
}