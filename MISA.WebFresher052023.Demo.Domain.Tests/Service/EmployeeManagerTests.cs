using MISA.WebFresher052023.Demo.Infrastructure;
using MISA.WebFresher052023.Demo.Infrastructure.UnitOfWork;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Domain.Tests.Service
{
    public class EmployeeManagerTests
    {
        [Test]
        public void CheckEmployeeExitByCode_ExistEmployee_ConflictException()
        {
            //Arange
            var code = "Helloworld";

            var employeeRepository = Substitute.For<IEmployeeRepository>();

            var employeeManager = new EmployeeManager(employeeRepository);

            employeeRepository.FindByCodeAsync(code).Returns(new EmployeeModel()); 
            //Act&Assert
            Assert.ThrowsAsync<ConflictException>(async () => await employeeManager.CheckEmployeeExitByCode(code));
            employeeRepository.Received(1).FindByCodeAsync(code);
        }

        [Test]
        public async Task CheckEmployeeExitByCode_NotExistEmployee_Success()
        {
            //Arange
            var code = "Helloworld";

            var employeeRepositoryFake = new EmployeeRepositoryFake();

            var employeeManager = new EmployeeManager(employeeRepositoryFake);
            //Act
            await employeeManager.CheckEmployeeExitByCode(code);

            //Assert
            Assert.That(employeeRepositoryFake.TotalCall, Is.EqualTo(1)); 
        }
    }
}
