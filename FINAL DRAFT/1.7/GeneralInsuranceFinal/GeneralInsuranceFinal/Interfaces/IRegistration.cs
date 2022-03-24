using GeneralInsuranceFinal.Models;
using System.Collections.Generic;

namespace GeneralInsuranceFinal.Interfaces
{
    public interface IRegistration
    {
        
        

            List<CustomerRegistration> GetALLCustomer();

            int AddCustomer(CustomerRegistration  customer);

          



        
    }

    
}
