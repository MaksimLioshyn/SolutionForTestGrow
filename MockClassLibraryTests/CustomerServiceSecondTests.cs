using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockClassLibrary;
using MockClassLibrary.CustonerForMoq;
using Moq;

namespace MockClassLibraryTests
{
    [TestClass()]
    public class CustomerServiceSecondTests
    {
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Create_AddressNotCreated_ExceptionThrown()
        {
            CustomerDto customer = new CustomerDto() { FirstName = "Ivan", LastName = "Ivanov", Email = "ivanov@test.com" };

            Mock<ICustomer> repositoryMock = new Mock<ICustomer>();
            Mock<IEmailBuilder> emailBuilderMock = new Mock<IEmailBuilder>();

            CustomerServiceSecond service = new CustomerServiceSecond(repositoryMock.Object, emailBuilderMock.Object);

            emailBuilderMock
                .Setup(x => x.From(It.IsAny<CustomerDto>()))
                .Returns<Address>(null);

            service.Create(customer);
        }

        [TestMethod]
        public void Create_AddressCreated_CustomerShouldBeSaved()
        {
            CustomerDto customer = new CustomerDto() { FirstName = "Ivan", LastName = "Ivanov", Email = "ivanov@test.com" };

            Mock<ICustomer> repositoryMock = new Mock<ICustomer>();
            Mock<IEmailBuilder> emailBuilderMock = new Mock<IEmailBuilder>();

            CustomerServiceSecond service = new CustomerServiceSecond(repositoryMock.Object, emailBuilderMock.Object);

            emailBuilderMock
                .Setup(x => x.From(It.IsAny<CustomerDto>())) 
                .Returns(new Address());

            service.Create(customer);

            repositoryMock.Verify(x => x.Save(It.IsAny<Customer>()));
        }
    }
}