using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.DataTransferObjects.Employee
{
    public record UpdateEmployeeDto(
        string FirstName,
        string LastName,
        string PhoneNumber,
        DateTimeOffset DateOffBorth,
        string CardNumber,
        string Type,
        decimal Salary);
}
