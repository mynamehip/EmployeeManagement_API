using Microsoft.AspNetCore.Mvc;
using MISA.WebFresher052023.Demo.Application;

namespace MISA.WebFresher052023.Demo
{
    public class BaseController<TEntityDto, TEntityCreateDto, TEntityUpdateDto> : BaseReadOnlyController<TEntityDto>
    {
        private readonly IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> _baseService;

        public BaseController(IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> baseService) : base(baseService)
        {
            _baseService = baseService;
        }

        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <returns></returns>
        /// Created by: tdhiep (12/07/2023)
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TEntityCreateDto entityCreateDto)
        {
            await _baseService.CreateAsync(entityCreateDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Sửa một nhân viên 
        /// </summary>
        /// <returns></returns>
        /// Created by: tdhiep (12/07/2023)
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] TEntityUpdateDto entityUpdateDto)
        {
            await _baseService.UpdateAsync(id, entityUpdateDto);
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Xóa một nhân viên
        /// </summary>
        /// <returns></returns>
        /// Created by: tdhiep (12/07/2023)
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _baseService.DeleteAsync(id);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete([FromBody] List<Guid> ids)
        {
            await _baseService.DeleteManyAsync(ids);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
