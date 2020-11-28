using System;
using SalaryCalculation.Data.Enums;

namespace SalaryCalculation.Data.Models
{
    public class Employee
    {
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeType Type { get; set; }
        public decimal? Salary { get; set; }
        public int? WorkingDays { get; set; }
        public int? DailyRate { get; set; }
        public int? ShiftHours { get; set; }
        public int? ShiftRate { get; set; }
    }
}
