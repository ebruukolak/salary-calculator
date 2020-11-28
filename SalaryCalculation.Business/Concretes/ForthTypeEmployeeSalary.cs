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
            if(employee.WorkingDays.HasValue && employee.DailyRate.HasValue && employee.ShiftHours.HasValue && employee.ShiftRate.HasValue)
            return (employee.WorkingDays.Value * employee.DailyRate.Value) + (employee.ShiftHours.Value * employee.ShiftRate.Value);

            return 0;
        }
    }
}
