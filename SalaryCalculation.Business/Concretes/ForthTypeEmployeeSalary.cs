using System;
using SalaryCalculation.Data.Enums;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class ForthTypeEmployeeSalary : ISalaryCalculator
    {
        public EmployeeType EmployeeType => EmployeeType.Fourth;

        public decimal Calculate(Employee employee)
        {
            return (employee.WorkingDays * employee.DailyRate) + (employee.ShiftHours * employee.ShiftRate);
        }
    }
}
