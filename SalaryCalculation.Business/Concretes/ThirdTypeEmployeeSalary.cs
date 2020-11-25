using System;
using SalaryCalculation.Data.Enums;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class ThirdTypeEmployeeSalary : ISalaryCalculator
    {
        public EmployeeType EmployeeType => EmployeeType.Third;

        public decimal Calculate(Employee employee)
        {
            return (employee.WorkingHours * employee.HourlyRate) + (employee.ShiftHours*employee.ShiftRate);
        }
    }
}
