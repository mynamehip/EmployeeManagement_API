using MISA.WebFresher052023.Demo.Domain;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MISA.WebFresher052023.Demo.Domain.Interface;
using AutoMapper;

namespace MISA.WebFresher052023.Demo.Application
{
    public class EmployeeService : BaseService<Employee, EmployeeModel, EmployeeDto, EmployeeCreateDto, EmployeeUpdateDto>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IEmployeeManager _employeeManager;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper, IEmployeeManager employeeManager) : base(employeeRepository, mapper)
        {
            _employeeRepository = employeeRepository;
            _employeeManager = employeeManager;
        }

        public async Task<string> GetNewCode()
        {
            var lastestCode = await _employeeRepository.GetNewCode();
            var newCode = lastestCode.ToString().Split('-')[1];
            int number = int.Parse(newCode);
            number++;
            newCode = "NV-" + number;
            return newCode;
        }

        public override async Task<Employee> MapCreateDtoToEntity(Guid id, EmployeeCreateDto entityCreateDto)
        {
            //Valide nghiệp vụ
            await _employeeManager.CheckEmployeeExitByCode(entityCreateDto.EmployeeCode);
            var employee = _mapper.Map<Employee>(entityCreateDto);
            employee.EmployeeId = id;
            employee.CreatedDate = DateTime.Now;
            employee.CreatedBy = "Tran Dinh Hiep";
            employee.ModifiedDate = DateTime.Now;
            employee.ModifiedBy = "Tran Dinh Hiep";
            return employee;
        }

        public override async Task<Employee> MapUpdateDtoToEntity(Guid id, EmployeeUpdateDto entityUpdateDto)
        {
            var employee = await _baseRepository.GetAsync(id);
            if (employee == null)
            {
                throw new Exception("Không tìm thấy nhân viên");
            }
            if (employee.EmployeeCode != entityUpdateDto.EmployeeCode)
            {
                await _employeeManager.CheckEmployeeExitByCode(entityUpdateDto.EmployeeCode);
            }
            employee = _mapper.Map<Employee>(entityUpdateDto);
            employee.EmployeeId = id;
            employee.ModifiedDate = DateTime.Now;
            employee.ModifiedBy = "Tran Dinh Hiep";
            return employee;
        }

    }
}
