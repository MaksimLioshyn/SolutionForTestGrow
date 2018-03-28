using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockClassLibrary.CustonerForMoq;

namespace MockClassLibrary
{
    public class CustomerServiceMockingProperties
    {
        ICustomer _customerRepository;
        IWorkstationSettings _workstationSettings;

        public CustomerServiceMockingProperties(ICustomer customerRepository, IWorkstationSettings workstationSettings)
        {
            _customerRepository = customerRepository;
            _workstationSettings = workstationSettings;
        }

        public void Create(CustomerDto customer)
        {
            Customer newCustomer = new Customer(customer.FirstName,customer.LastName);
            int? id = _workstationSettings.WorkstationId;

            if (!id.HasValue)
            {
                throw new ApplicationException();
            }

            newCustomer.WorkstationId = id;
            _customerRepository.LocalTimeZone = TimeZone.CurrentTimeZone.StandardName;

            _customerRepository.Save(newCustomer);
        }
    }
}
