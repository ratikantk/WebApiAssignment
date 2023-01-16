using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataWebApi.Models
{
    public class Employee
    {

        [Key]       
        public int EmpId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? FirstName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? LastName { get; set; }
        public string? Designation { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Email { get; set; }
        
    }
}
