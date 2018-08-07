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
        [SSNValidation]
        [StringLength(10,MinimumLength =10, ErrorMessage = "Personal Number should be 10 Charactares")]
        public string PersonalNumber { get; set; }
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
    public class SSNValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;

            }

            int j = 0;                      
            int Dany = 0;
            string nr = (string)value;
            for (int i = 0; i <= 9; i += 2)
            {
                Dany = Convert.ToInt16(nr[i]);
                int temp = 1;
                temp = Dany * 2;
                if (temp > 9)
                {
                    temp = 1 + (temp - 10);                   
                }
                j = j+ temp + Convert.ToInt32(nr[i + 1]);                
                //if (i <= 9) {
                //    Dany1 = Convert.ToInt32(nr[i + 1]);
                //    int temp1 = 1;
                //    temp1 = Dany1 * 1;                    
                //        j += temp1;     
                //}

            }
            if (j % 10 == nr[9])
            {
                return ValidationResult.Success;
            }
            else

              return new ValidationResult("Not a valid Swedish SSN number"+nr[9]+"  "+j);                      
        }
           
    }
}
