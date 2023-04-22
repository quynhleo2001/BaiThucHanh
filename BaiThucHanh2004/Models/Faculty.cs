using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh2004.Models
{
    [Table("Facultys")]
    public class Faculty
    {       
    [Key]
    public string FacultyID {get; set;}
    public string FacultyName {get; set;}

    }
}