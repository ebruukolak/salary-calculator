using System;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Interfaces
{

    public interface ISalaryCalculatorFactory
    {
        public ISalaryCalculator GetSalaryCalculator(Employee employee);
    }

}
