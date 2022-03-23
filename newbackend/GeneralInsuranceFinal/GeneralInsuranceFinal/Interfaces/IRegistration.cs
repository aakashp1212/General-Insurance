﻿namespace GeneralInsuranceFinal.Interfaces
{
    public interface IRegistration
    {
        
        

            List<CustomerRegistration> GetALLCustomer();

            int AddCustomer(CustomerRegistration customer);

            CustomerRegistration GetCustomerById(long CustomerId);



        
    }
}
