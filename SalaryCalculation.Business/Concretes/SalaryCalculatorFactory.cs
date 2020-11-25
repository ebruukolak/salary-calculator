using System;
using System.Collections.Generic;
using System.Linq;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class SalaryCalculatorFactory : ISalaryCalculatorFactory
    {
        private readonly IEnumerable<ISalaryCalculator> availableStrategies;

        public SalaryCalculatorFactory(IEnumerable<ISalaryCalculator> availableStrategies)
        {
            this.availableStrategies = availableStrategies;
        }

        public ISalaryCalculator GetSalaryCalculator(Employee employee)
        {
            var supportedStrategy = availableStrategies
                    .FirstOrDefault(x => x.EmployeeType == employee.Type);
            if (supportedStrategy == null)
            {
                throw new InvalidOperationException($"No supported strategy found for salary calculation method '{employee.Type}'.");
            }

            return supportedStrategy;
        }
    }
}
