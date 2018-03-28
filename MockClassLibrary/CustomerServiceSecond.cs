using System;
using MockClassLibrary.CustonerForMoq;

namespace MockClassLibrary
{
    public class CustomerServiceSecond
    {
        private ICustomer _repositry;
        private IEmailBuilder _emailBuilder;

        public CustomerServiceSecond(ICustomer repository, IEmailBuilder emailBuilder)
        {
            _repositry = repository;
            _emailBuilder = emailBuilder;
        }

        public void Create(CustomerDto customerDto)
        {
            Customer customer =
                new Customer(customerDto.FirstName, customerDto.LastName) {Email = _emailBuilder.From(customerDto)};

            if (customer.Email == null)
            {
                throw new ApplicationException("Email не может быть пустым.");
            }

            _repositry.Save(customer);
        }
    }
}
