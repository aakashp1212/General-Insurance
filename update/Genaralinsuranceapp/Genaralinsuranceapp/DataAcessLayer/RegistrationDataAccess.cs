using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Genaralinsuranceapp.DataAcessLayer
{
    public class RegistrationDataAccess : IRegistration
    {
        private generalinsuranceContext db;

        public RegistrationDataAccess(generalinsuranceContext _db)
        {
            db = _db; 
        }

        public int AddCustomer(CustomerRegistration customer)
        {
            try
            {
                db.CustomerRegistration.Add(customer);
                db.SaveChanges();
                return 1;   
            }
            catch
            {
                throw;
            }
            
        }

        public IEnumerable<CustomerRegistration> GetALLCustomer()
        {
            try
            {
                return db.CustomerRegistration?.ToList().OrderBy(x => x.PolicyNumber);
            }
            catch
            {
                throw;
            }
        }

        public CustomerRegistration GetCustomerById(int PolicyNumber)
        {
            try
            {
                CustomerRegistration customer = db.CustomerRegistration.Find(PolicyNumber);
                    return customer;
            }
            catch
            {
                throw;
            }
        }
    }

}     