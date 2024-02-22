
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain
{
    public interface IEmployeeRepository : IBaseRepository<Employee, EmployeeModel>
    {
        /// <summary>
        /// Tìm nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="code"></param>
        /// <returns>Nhân viên</returns>
        /// Created by: tdhiep (17/07/2023)
        Task<Employee?> FindByCodeAsync(string code);

        Task<string?> GetNewCode();
    }
}
