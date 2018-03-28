using System.Collections.Generic;
using MockClassLibrary.CustonerForMoq;

namespace MockClassLibrary
{
    public class CustomerServiceFird
    {
        private IIdFactory _idFactory;
        private ICustomer _repositry;

        public CustomerServiceFird(ICustomer repository, IIdFactory idFactory)
        {
            _repositry = repository;
            _idFactory = idFactory;
        }

        public void Create(IEnumerable<CustomerDto> customers)
        {
            foreach (var currentCustomer in customers)
            {
                Customer newCustomer = new Customer(currentCustomer.FirstName, currentCustomer.LastName);
                newCustomer.Id = _idFactory.Create();
                _repositry.Save(newCustomer);
            }
        }
    }
}
