using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Application;

namespace MISA.WebFresher052023.Demo.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentController : BaseReadOnlyController<DepartmentDto>
    {
        public DepartmentController(IDepartmentService departmentService) : base(departmentService)
        {
        }
    }
}
