using System;
using SalaryCalculation.Data.Enums;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Interfaces
{
    public interface ISalaryCalculator
    {
        EmployeeType EmployeeType { get; }
        decimal Calculate(Employee employee  );
    }
}
