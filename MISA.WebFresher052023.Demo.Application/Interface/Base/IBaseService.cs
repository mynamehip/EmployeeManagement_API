using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public interface IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> : IReadOnlyService<TEntityDto>
    {
        /// <summary>
        /// Thên nhân viên
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task CreateAsync(TEntityCreateDto entityCreateDto);


        /// <summary>
        /// Sửa nhân viên
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task UpdateAsync(Guid id, TEntityUpdateDto entityUpdateDto);

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task DeleteAsync(Guid id);
        Task DeleteManyAsync(List<Guid> ids);
    }
}
