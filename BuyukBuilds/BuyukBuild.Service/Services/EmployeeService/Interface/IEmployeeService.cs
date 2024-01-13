using BuyukBuild.Domain.DataTransferObjects.Employee;
using BuyukBuild.Domain.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Services.EmployeeService.Interface
{
    public interface IEmployeeService
    {
        Task<Employee> GetByIdAsync(long id);
        Task<IQueryable<Employee>> GetByPhoneNumberAsync(string phone);
        Task<IQueryable<Employee>> GetByEmailAsync(string email);
        Task<Employee> DeleteByIdAsync(long id);
        Task<Employee> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
        Task<Employee> CreateEmployeeAsync(CreateEmpoyeeDto createEmpoyeeDto);

    }
}
