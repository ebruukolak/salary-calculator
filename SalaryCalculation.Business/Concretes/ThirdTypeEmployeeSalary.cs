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
            if(employee.Salary.HasValue && employee.ShiftHours.HasValue && employee.ShiftRate.HasValue)
              return (employee.Salary.Value) + (employee.ShiftHours.Value*employee.ShiftRate.Value);
            return 0;
        }
    }
}
