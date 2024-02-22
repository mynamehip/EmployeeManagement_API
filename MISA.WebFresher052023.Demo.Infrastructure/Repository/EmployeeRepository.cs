using Dapper;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Entity;
using MISA.WebFresher052023.Demo.Domain.Interface;
using MISA.WebFresher052023.Demo.Infrastructure.Repository.Base;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Infrastructure
{
    public class EmployeeRepository : BaseRepository<Employee, EmployeeModel>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public async Task<Employee?> FindByCodeAsync(string code)
        {
            var sql = $"SELECT * FROM Employee WHERE EmployeeCode = @code;";

            var parameters = new DynamicParameters();
            parameters.Add("@code", code);

            var result = await _uow.Connection.QueryFirstOrDefaultAsync<Employee>(sql, parameters, transaction: _uow.Transaction);

            return result;

        }

        public async Task<string?> GetNewCode()
        {
            var sql = "SELECT e.EmployeeCode FROM employee e ORDER BY e.CreatedDate DESC LIMIT 1;";
            var result = await _uow.Connection.QueryFirstOrDefaultAsync<string>(sql, transaction: _uow.Transaction);
            return result;
        }
    }
}
