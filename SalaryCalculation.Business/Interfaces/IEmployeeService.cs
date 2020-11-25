using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalaryCalculation.Business.Models;

namespace SalaryCalculation.Business.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDTO>> GetEmployeeListAsync();
    }
}
