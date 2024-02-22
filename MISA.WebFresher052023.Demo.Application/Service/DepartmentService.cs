using AutoMapper;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Entity;
using MISA.WebFresher052023.Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public class DepartmentService : BaseReadOnlyService<Department, Department, DepartmentDto>, IDepartmentService
    {
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper) : base(departmentRepository, mapper)
        {
        }
    }
}
