using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public interface IReadOnlyService<TEntityDto>
    {
        /// <summary>
        ///Lấy tất cả nhân viên
        /// </summary>
        /// <returns>Tất cả nhân viên</returns>
        /// Created by: tdhiep (17/07/2023)
        Task<IEnumerable<TEntityDto>> GetAllAsync();

        /// <summary>
        ///Lấy nhân viên theo id
        /// </summary>
        /// <param name="id">Định danh nhân viên</param>
        /// <returns>Nhân viên</returns>
        /// Created by: tdhiep (17/07/2023)
        Task<TEntityDto> GetAsync(Guid id);
    }
}
