using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
{
    public interface IRegistration
    {

        IEnumerable<CustomerRegistration> GetALLCustomer();

        int AddCustomer(CustomerRegistration customer); 

        CustomerRegistration GetCustomerById (int PolicyNumber);
    }
}
