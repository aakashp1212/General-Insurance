namespace GeneralInsuranceFinal.DataAccessLayer
{
    public class Registrationdao
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
}
