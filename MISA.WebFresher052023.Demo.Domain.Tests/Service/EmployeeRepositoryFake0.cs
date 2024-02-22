using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain.Tests.Service
{
    public class EmployeeRepositoryFake0 : IEmployeeRepository
    {
        public int TotalCall { get; set; }

        public Task DeleteAsync(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(List<EmployeeModel> entities)
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel?> FindByCodeAsync(string code)
        {
            TotalCall++;
            return Task.FromResult<EmployeeModel?>(new EmployeeModel());
        }

        public Task<EmployeeModel?> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
