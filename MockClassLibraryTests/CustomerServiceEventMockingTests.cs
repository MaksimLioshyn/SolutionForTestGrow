using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockClassLibrary;
using MockClassLibrary.CustonerForMoq;
using Moq;

namespace MockClassLibraryTests
{
    [TestClass()]
    public class CustomerServiceEventMockingTests
    {
        [TestMethod]
        public void Create_NotifyEventRised()
        {
            Mock<ICustomer> customerRepositoryMock = new Mock<ICustomer>();
            Mock<IMailing> mailingRepsoitoryMock = new Mock<IMailing>();
            CustomerServiceEventMocking service = new CustomerServiceEventMocking(customerRepositoryMock.Object, mailingRepsoitoryMock.Object);

            customerRepositoryMock.Raise(x => x.Notify += null, new NotifyEventArgs("Ivan"));

            mailingRepsoitoryMock.Verify(x => x.CreatenewMessage(It.IsAny<string>()));
        }
    }
}