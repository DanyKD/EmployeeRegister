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
        public string Department { get; set; }
    }
    //public enum Department
    //{
    //    Sales = 1,
    //    SupplyChain = 2,
    //    HR = 3,
    //    Finance = 4,
    //    Sport = 5,
    //    Factory = 6,
    //    Education=7,
    //}
}
