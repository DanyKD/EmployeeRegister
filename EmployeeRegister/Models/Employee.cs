using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeRegister.Models
{
    public class Employee
    {
        public int Id { get; set; }       
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; }
    }
    public enum Department
    {
        Education = 1,
        Factory = 2,
        Finance = 3,
        HR = 4,        
        Sales = 5,
        Sport = 6,
        SupplyChain = 7,
    }
}
