using System.Collections.Generic;
using MockClassLibrary.CustonerForMoq;

namespace MockClassLibrary
{
    public class CustomerServiceFirst
    {
        private ICustomer _repositry;

        public CustomerServiceFirst(ICustomer repository)
        {
            _repositry = repository;
        }

        public void Create(IEnumerable<CustomerDto> customers)
        {
            foreach (var customer in customers)
            {
                _repositry.Save(new Customer(customer.FirstName, customer.LastName));
            }
        }
    }
}
