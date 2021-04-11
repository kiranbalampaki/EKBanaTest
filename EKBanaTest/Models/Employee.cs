using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EKBanaTest.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee's Name is Required")]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Employee's Address is Required")]
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Employee's Salary is Required")]
        public decimal Salary { get; set; }
    }
}
