using MISA.WebFresher052023.Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task CheckEmployeeExitByCode(string code)
        {
            //Check trùng mã nhân viên
            var employeeExist = await _employeeRepository.FindByCodeAsync(code);

            if (employeeExist != null)
            {
                throw new ConflictException();
            }
        }
    }
}
