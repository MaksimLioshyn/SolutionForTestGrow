using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockClassLibrary;
using MockClassLibrary.CustonerForMoq;
using Moq;

namespace MockClassLibraryTests
{
    [TestClass()]
    public class CustomerServiceFirdTests
    {
        [TestMethod]
        public void CreateId()
        {
            // arrange
            // arrange
            List<CustomerDto> list = new List<CustomerDto>() {
                new CustomerDto() { FirstName ="Ivan", LastName="Ivanov" },
                new CustomerDto() { FirstName ="Petr", LastName="Petrov" },
                new CustomerDto() { FirstName ="Fedor", LastName="Fedorov" }
            };

            Mock<ICustomer> customerRepositoyMock = new Mock<ICustomer>();
            Mock<IIdFactory> factoryMock = new Mock<IIdFactory>();
            CustomerServiceFird service = new CustomerServiceFird(customerRepositoyMock.Object, factoryMock.Object);

            int id = 1;
            factoryMock
                .Setup(x => x.Create()) 
                .Returns(() => id)      
                .Callback(() => id++);  

            // act
            service.Create(list);

            // assert
            customerRepositoyMock.Verify(x => x.Save(It.IsAny<Customer>()));
            factoryMock.Verify(x => x.Create(), Times.AtLeastOnce);
        }
    }
}