using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Application;

namespace MISA.WebFresher052023.Demo
{
    public abstract class BaseReadOnlyController<TEntityDto> : ControllerBase
    {
        private readonly IReadOnlyService<TEntityDto> _readOnlyService;

        protected BaseReadOnlyController(IReadOnlyService<TEntityDto> readOnlyService)
        {
            _readOnlyService = readOnlyService;
        }

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        /// Created by: tdhiep (12/07/2023)
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _readOnlyService.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, result);
        }

        /// <summary>
        /// Lấy chi tiết một nhân viên
        /// </summary>
        /// <returns></returns>
        /// Created by: tdhiep (12/07/2023)
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _readOnlyService.GetAsync(id);
            return StatusCode(StatusCodes.Status200OK, result);
        }


    }
}
