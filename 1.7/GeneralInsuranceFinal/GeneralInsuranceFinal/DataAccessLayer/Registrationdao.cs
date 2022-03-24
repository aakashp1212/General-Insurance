using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneralInsuranceFinal.DataAccessLayer
{
   
        public class Registrationdao : IRegistration
        {
            private General_InsuranceDatabaseContext db;


            public Registrationdao(General_InsuranceDatabaseContext _db)
            {
                db = _db;
            }

            public int AddCustomer(CustomerRegistration customer)
            {
                db.CustomerRegistration.Add(customer);
                return db.SaveChanges();
            }



            public List<CustomerRegistration> GetALLCustomer()
            {
                return db.CustomerRegistration.ToList<CustomerRegistration>();

            }

            public CustomerRegistration GetCustomerById(long id)
            {
                return db.CustomerRegistration.Where(p => p.CustomerId == id).First<CustomerRegistration>();
            }


        }
    
}
