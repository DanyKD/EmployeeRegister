using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string LastName { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
}