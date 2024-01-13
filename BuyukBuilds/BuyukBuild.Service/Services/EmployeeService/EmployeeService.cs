using BuyukBuild.Domain.DataTransferObjects.Employee;
using BuyukBuild.Domain.Entities.Employees;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using BuyukBuild.Service.Services.EmployeeService.Interface;
using BuyukBuild.Service.Validations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepsoitory;

        public EmployeeService(IEmployeeRepository employeeRepsoitory)
        {
            this.employeeRepsoitory = employeeRepsoitory;
        }
        public async Task<Employee> CreateEmployeeAsync(CreateEmpoyeeDto createEmpoyeeDto)
        {
            ValidationExceptionIsNull.ValidationIsNullModel(createEmpoyeeDto);
            
            var emp = new Employee()
            {
                FirstName = createEmpoyeeDto.FirstName,
                LastName = createEmpoyeeDto.LastName,
                CardNumber = createEmpoyeeDto.CardNumber,
                DateOfBrith = createEmpoyeeDto.DateOffBorth,
                PhoneNumber = createEmpoyeeDto.PhoneNumber,
                Salary = createEmpoyeeDto.Salary,
                Type = createEmpoyeeDto.Type,
            };

            var result = await this.employeeRepsoitory.AddAsync(emp);
            return result;
        }

        public async Task<Employee> DeleteByIdAsync(long id)
        {
            ValidationExceptionIsNull.ValidationIsNullById(id);

            var result  = await this.employeeRepsoitory.DeleteAsync(id);
            return result;
        }

        public async Task<IQueryable<Employee>> GetByEmailAsync(string email)
        {
            ValidationExceptionIsNull.ValidationIsNullByName(email);

            var result = this.employeeRepsoitory.GetAllAsQueryable().Where(x => EF.Functions.ILike(x.Email, $"%{email}@gmail.com"));
            return result;
        }

        public async Task<Employee> GetByIdAsync(long id)
        {
            ValidationExceptionIsNull.ValidationIsNullById(id);
            var result = await this.employeeRepsoitory.GetByIdAsync(id);
            return result;
        }

        public async Task<IQueryable<Employee>> GetByPhoneNumberAsync(string phone)
        {
            ValidationExceptionIsNull.ValidationIsNullByName(phone);

            var result = this.employeeRepsoitory.GetAllAsQueryable().Where(x => EF.Functions.ILike(x.PhoneNumber, $"%{phone}%"));
            return result;
        }

        public async Task<Employee> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            ValidationExceptionIsNull.ValidationIsNullModel(updateEmployeeDto);
            var emp = new Employee()
            {
                FirstName = updateEmployeeDto.FirstName,
                LastName = updateEmployeeDto.LastName,
                CardNumber = updateEmployeeDto.CardNumber,
                DateOfBrith = updateEmployeeDto.DateOffBorth,
                PhoneNumber = updateEmployeeDto.PhoneNumber,
                Salary = updateEmployeeDto.Salary,
                Type = updateEmployeeDto.Type,
            };

            var result = await this.employeeRepsoitory.UpdateAsync(emp);
            return result;
        }
    }
}
