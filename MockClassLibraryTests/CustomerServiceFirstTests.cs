using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockClassLibrary;
using MockClassLibrary.CustonerForMoq;
using Moq;

namespace MockClassLibraryTests
{
    [TestClass()]
    public class CustomerServiceFirstTests
    {
        [TestMethod]
        public void CreateMethod_Save_WasCalled()
        {
            // arrange
            List<CustomerDto> list = new List<CustomerDto>() {
                new CustomerDto() { FirstName ="Ivan", LastName="Ivanov" },
                new CustomerDto() { FirstName ="Petr", LastName="Petrov" },
                new CustomerDto() { FirstName ="Fedor", LastName="Fedorov" }
            };

            Mock<ICustomer> mock = new Mock<ICustomer>();
            ICustomer repository = mock.Object;
            CustomerServiceFirst customerService = new CustomerServiceFirst(repository);

            // act
            customerService.Create(list);

            // assert
            mock.Verify(x => x.Save(It.IsAny<Customer>()));
        }

        [TestMethod]
        public void CreateMethod_Save_WassCalled_ThreeTimes()
        {
            // arrange
            List<CustomerDto> list = new List<CustomerDto>() {
                new CustomerDto() { FirstName ="Ivan", LastName="Ivanov" },
                new CustomerDto() { FirstName ="Petr", LastName="Petrov" },
                new CustomerDto() { FirstName ="Fedor", LastName="Fedorov" }
            };

            Mock<ICustomer> mock = new Mock<ICustomer>();
            ICustomer repository = mock.Object;
            CustomerServiceFirst customerService = new CustomerServiceFirst(repository);

            // act
            customerService.Create(list);

            // assert
            mock.Verify(x => x.Save(It.IsAny<Customer>()), Times.Exactly(3));
        }
    }
}