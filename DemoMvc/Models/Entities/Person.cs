using System.ComponentModel.DataAnnotations;
using Microsoft.JSInterop.Infrastructure;

namespace DemoMvc.Models.Entities
{
       public class Person 
    {
        [Key]
     public string PersonID {get;set;}
     public string Hoten {get;set;}
     public string Quequan {get;set;}
    } 
}