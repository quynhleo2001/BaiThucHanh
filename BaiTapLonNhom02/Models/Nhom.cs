using System.ComponentModel.DataAnnotations;
namespace BaiTapLonNhom02.Models
{
    public class Nhom
    {
        [Key]
        public string? MaNhom{get; set;}
        public string? TenNhom{get; set;}
    }
}