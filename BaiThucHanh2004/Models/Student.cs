using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh2004.Models
{
    [Table("Students")]
    public class Student
    {
        public string  StudentID {get; set;}
        public string FullName {get; set;}
        public string FacultyID {get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty {get; set;}

    }
}