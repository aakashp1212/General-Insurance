using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
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



        public int Updatepolicy(int id, Policydetails policydetails)
        {
            var entity = db.Policydetails.Where(n => n.PolicyNumber == id);
            if (entity != null) ;
            return db.SaveChanges();


        }



        //public int Updatepolicy(Policydetails policydetails)
        //{
        //    db.Entry(policydetails).State = EntityState.Modified;
        //    return db.SaveChanges();

        //}


    }
}