using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GeneralInsuranceFinal.DataAccessLayer
{
    public class Renewdao : IRenew
    {

        private General_InsuranceDatabaseContext db;


        public Renewdao(General_InsuranceDatabaseContext _db)
        {
            db = _db;
        }

        //public List<Policydetails> GetAllPolicies()
        //{
        //    return db.Policydetails.ToList<Policydetails>();
        //}

        //public CustomerRegistration GetPolicyByEmail(string email)
        //{
        //    return db.CustomerRegistration.Where(p => p.Email == email).First<CustomerRegistration>();
        //}



        public int Updatepolicy(Policydetails policydetails)
        {
            var details = db.Policydetails.Where(n => n.PolicyNumber == policydetails.PolicyNumber).FirstOrDefault<Policydetails>();
            if (details != null)
            {
                details.PolicyNumber = policydetails.PolicyNumber;
                details.DurationValue = policydetails.DurationValue;
                details.VehicleType = policydetails.VehicleType;
                details.PolicyNumber = policydetails.PolicyNumber;
                details.PlanName = policydetails.PlanName;
                db.SaveChanges();

            }

            return db.SaveChanges();


        }



        //public int Updatepolicy(Policydetails policydetails)
        //{
        //    db.Entry(policydetails).State = EntityState.Modified;
        //    return db.SaveChanges();

        //}


    }
}