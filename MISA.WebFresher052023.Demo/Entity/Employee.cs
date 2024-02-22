using MISA.WebFresher052023.Demo.Enum;
using System.Diagnostics.CodeAnalysis;

namespace MISA.WebFresher052023.Demo.Entity
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        [NotNull]
        public string EmployeeCode { get; set; }

        [NotNull]
        public string FullName { get; set; }

        public Gender Gender { get; set; }


    }
}
