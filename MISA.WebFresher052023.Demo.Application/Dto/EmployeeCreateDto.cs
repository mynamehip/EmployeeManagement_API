using MISA.WebFresher052023.Demo.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public class EmployeeCreateDto
    {
        public string EmployeeCode { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        public Guid? DepartmentId { get; set; }

        public Guid? PositionId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string? IdentityNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public string? IssuePlace { get; set; }

        public string? Address { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? BankNumber { get; set; }

        public string? BankName { get; set; }

        public string? BankBranches { get; set; }

    }
}
