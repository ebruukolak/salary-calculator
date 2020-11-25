using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalaryCalculation.Business.Interfaces;
using SalaryCalculation.Business.Models;
using SalaryCalculation.Data.Models;

namespace SalaryCalculation.Business.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ISalaryCalculatorFactory _salaryCalculatorFactory;
        private List<Employee> _employees = new List<Employee>
        {
            new Employee {IdentityNumber="123456789101",Name="Ebru",Surname="Kolak",Type=Data.Enums.EmployeeType.First,WorkingHours=8,HourlyRate=25,WorkingDays=5,DailyRate=200,ShiftHours=5,ShiftRate=50},
            new Employee {IdentityNumber="123456789102",Name="Ali",Surname="Veli",Type=Data.Enums.EmployeeType.Second,WorkingHours=9,HourlyRate=30,WorkingDays=5,DailyRate=270,ShiftHours=8,ShiftRate=60},
            new Employee {IdentityNumber="123456789103",Name="Emre",Surname="Eren",Type=Data.Enums.EmployeeType.Third,WorkingHours=10,HourlyRate=35,WorkingDays=5,DailyRate=200,ShiftHours=2,ShiftRate=70},
            new Employee {IdentityNumber="123456789104",Name="Eda",Surname="Okyay",Type=Data.Enums.EmployeeType.Fourth,WorkingHours=11,HourlyRate=20,WorkingDays=5,DailyRate=220,ShiftHours=4,ShiftRate=40},
        };

        public EmployeeService(ISalaryCalculatorFactory salaryCalculatorFactory)
        {
            _salaryCalculatorFactory = salaryCalculatorFactory;
        }

        public async Task<List<EmployeeDTO>> GetEmployeeListAsync()
        {
            return await Task.Run(() => _employees.Select(s => new EmployeeDTO
            {
                IdentityNumber = s.IdentityNumber,
                Name = s.Name,
                Surname = s.Surname,
                Salary = _salaryCalculatorFactory.GetSalaryCalculator(s).Calculate(s)
            }).ToList());
        }
    }
}
