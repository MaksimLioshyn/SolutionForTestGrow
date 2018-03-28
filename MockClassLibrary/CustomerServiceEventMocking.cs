using MockClassLibrary.CustonerForMoq;

namespace MockClassLibrary
{
    public class CustomerServiceEventMocking
    {
        ICustomer _customerRepository;
        IMailing _mailingRepository;

        public CustomerServiceEventMocking(ICustomer customerRepository, IMailing mailingRepository)
        {
            _customerRepository = customerRepository;
            _mailingRepository = mailingRepository;
            _customerRepository.Notify += CustomerRepository_Notify;
        }

        private void CustomerRepository_Notify(object sender, NotifyEventArgs e) => _mailingRepository.CreatenewMessage(e.CustomerName);

        public void Create(CustomerDto customer)
        {
            Customer newCustomer = new Customer(customer.FirstName, customer.LastName);

            _customerRepository.Save(newCustomer);
        }
    }
}
