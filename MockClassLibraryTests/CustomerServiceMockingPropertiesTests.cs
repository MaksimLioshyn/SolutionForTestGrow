using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockClassLibrary;
using MockClassLibrary.CustonerForMoq;
using Moq;

namespace MockClassLibraryTests
{
    [TestClass()]
    public class CustomerServiceMockingPropertiesTests
    {
        [TestMethod]
        public void Create_ShouldSetTimeZone_AndCallSave()
        {
            Mock<ICustomer> repositoryMock = new Mock<ICustomer>();
            Mock<IWorkstationSettings> workstationSettingsMock = new Mock<IWorkstationSettings>();

            CustomerServiceMockingProperties service = new CustomerServiceMockingProperties(repositoryMock.Object, workstationSettingsMock.Object);
            workstationSettingsMock.Setup(x => x.WorkstationId).Returns(111);

            service.Create(new CustomerDto());

            repositoryMock.VerifySet(x => x.LocalTimeZone = It.IsAny<string>());
            repositoryMock.Verify(x => x.Save(It.IsAny<Customer>()));
        }
    }
}