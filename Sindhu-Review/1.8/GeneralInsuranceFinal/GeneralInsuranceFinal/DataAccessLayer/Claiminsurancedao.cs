using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneralInsuranceFinal.DataAccessLayer
{
    public class Claiminsurancedao : IClaim
    {
       

            private General_InsuranceDatabaseContext db;


            public Claiminsurancedao(General_InsuranceDatabaseContext _db) => db = _db;


            public int AddClaimdetails(Claimhistory claimdata)
            {
                db.Claimhistory.Add(claimdata);
                return db.SaveChanges();
            }

        

            public List<Claimreasons> Getclaimreasons()
            {
                List<Claimreasons> reasons = new List<Claimreasons>();
                reasons = (from reason in db.Claimreasons select reason).ToList();
                return reasons;
            }

            public CustomerRegistration GetPolicyByEmail(string email)
            {
                return db.CustomerRegistration.Where(p => p.Email == email).First<CustomerRegistration>();
            }

       

      
    }
}
