using AutoMapper;
using MISA.WebFresher052023.Demo.Domain;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application.Tests
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        public IEmployeeRepository employeeRepository { get; set; }
        public IMapper mapper { get; set; }
        public IEmployeeManager employeeManager { get; set; }

        [SetUp]
        public void Setup()
        {
            employeeRepository = Substitute.For<IEmployeeRepository>();
        }

        [Test]
        public async Task DeleteManyAsync_EmployeeList_ThrowException()
        {
            //Arrage
            var ids = new List<Guid>();

            //Act & Assert
        }
    }
}
