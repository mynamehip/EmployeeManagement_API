using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain
{
    public class EmployeeModel : BaseAuditEntity, IHasKey
    {
        public Guid EmployeeId { get; set; }

        public string EmployeeCode { get; set; }

        public string FullName { get; set; }

        public Guid? DepartmentId { get; set; }

        public string? DepartmentName { get; set; }

        public Guid? PositionId { get; set; }

        public string? PositionName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Gender? Gender { get; set; }

        public string? IdentityNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public string? IssuePlace { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? BankNumber { get; set; }

        public string? BankName { get; set; }

        public string? BankBranches { get; set; }

        public Guid GetKey()
        {
            return EmployeeId;
        }
    }
}
