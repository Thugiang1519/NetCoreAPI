using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
       public class Student
    {
        [Key]
    public string StudentID { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }
    } 
}