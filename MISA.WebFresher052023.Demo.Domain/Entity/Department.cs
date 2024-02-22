using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.WebFresher052023.Demo.Domain.Entity.Base;

namespace MISA.WebFresher052023.Demo.Domain.Entity
{
    public class Department : BaseAuditEntity, IHasKey
    {
        public Guid DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public Guid GetKey()
        {
            return DepartmentId;
        }
    }
}
