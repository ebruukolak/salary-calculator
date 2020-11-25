using System;
using SalaryCalculation.Data.Enums;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class FirstTypeEmployeeSalary : ISalaryCalculator
    {
        public EmployeeType EmployeeType => EmployeeType.First;

        public decimal Calculate(Employee employee)
        {
            return employee.HourlyRate * employee.WorkingHours;
        }
    }
}
