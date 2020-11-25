using System;
namespace SalaryCalculation.Business.Models
{
    public class EmployeeDTO
    {
        public String IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
    }
}
