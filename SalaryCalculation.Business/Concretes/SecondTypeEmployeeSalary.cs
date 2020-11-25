using System;
using SalaryCalculation.Data.Enums;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class SecondTypeEmployeeSalary : ISalaryCalculator
    {
        public EmployeeType EmployeeType => EmployeeType.Second;

        public decimal Calculate(Employee employee)
        {
            return employee.WorkingDays * employee.DailyRate;
        }
    }
}
