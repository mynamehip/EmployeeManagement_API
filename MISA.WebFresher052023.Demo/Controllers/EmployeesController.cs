using Dapper;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Application;
using System.Security.Cryptography.X509Certificates;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.WebFresher052023.Demo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : BaseController<EmployeeDto, EmployeeCreateDto, EmployeeUpdateDto>
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("GetNewEmployeeCode")]
        public async Task<IActionResult> GetNewEmployeeCode()
        {
            var newCode = await _employeeService.GetNewCode();
            return StatusCode(StatusCodes.Status200OK, newCode);
        }
    }
}
