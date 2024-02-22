using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Application;
using MISA.WebFresher052023.Demo.Application.Dto;
using MISA.WebFresher052023.Demo.Application.Interface;

namespace MISA.WebFresher052023.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : BaseReadOnlyController<PositionDto>
    {
        public PositionController(IPositionService positionService) : base(positionService)
        {
        }
    }
}
