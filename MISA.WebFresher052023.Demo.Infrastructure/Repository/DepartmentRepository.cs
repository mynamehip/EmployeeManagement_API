using MISA.WebFresher052023.Demo.Domain.Entity;
using MISA.WebFresher052023.Demo.Domain.Interface;
using MISA.WebFresher052023.Demo.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Infrastructure
{
    public class DepartmentRepository : BaseReadonlyRepository<Department, Department>, IDepartmentRepository
    {
        public DepartmentRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
