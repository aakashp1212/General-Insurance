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

        

        

        //public int AddCustomer(CustomerRegistration customer)
        //{
        //    db.Login.Add(new login { email = customer.Email, password = customer.Password });
        //    int res = db.SaveChanges();
        //    if (res > 0)
        //    {
        //        db.CustomerRegistration.Add(new Models.CustomerRegistration
        //        {
        //            FirstName = customer.FirstName,
        //            Address = customer.Address,
        //            ContactNo = customer.ContactNo,
        //            Email = customer.Email
        //        });

        //        return db.SaveChanges();
        //    }
        //}
        




        public List<CustomerRegistration> GetALLCustomer()
            {
                return db.CustomerRegistration.ToList<CustomerRegistration>();

            }


        public int AddCustomer(CustomerRegistration customer, Login login)
        {

            //CustomerRegistration customer = new CustomerRegistration();
           // Login login = new Login();
            db.Login.Add(new login { email = login.Email, password = login.Password });
            int res = db.SaveChanges();
            if (res > 0)
            {
                db.CustomerRegistration.Add(new CustomerRegistration
                {
                    FirstName = customer.FirstName,
                    Address = customer.Address,
                    ContactNo = customer.ContactNo,
                    Email = customer.Email
                });
                int result = db.SaveChanges();
                return result;

            }
                return res;
            }   
    }
    
}
