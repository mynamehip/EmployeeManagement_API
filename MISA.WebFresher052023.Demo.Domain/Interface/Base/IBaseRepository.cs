using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain
{
    public interface IBaseRepository<TEntity, TModel> : IReadOnlyRepository<TEntity, TModel>
    {
        /// <summary>
        /// Thên nhân viên
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task InsertAsync(TEntity entity);


        /// <summary>
        /// Sửa nhân viên
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// Created by: tdhiep (17/07/2023)
        Task DeleteAsync(TEntity entity);

        Task DeleteManyAsync(List<TEntity> entities);
    }
}
