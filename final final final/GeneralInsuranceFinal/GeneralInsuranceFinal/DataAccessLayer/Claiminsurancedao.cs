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


        //this is if we want to display all policy details of the user
        public Policydetails GetPolicydetails(int id)
        {
            return db.Policydetails.Where(p => p.PolicyNumber == id).First<Policydetails>();
        }

        List<Claimreasons> IClaim.Getclaimreasons()
        {
            throw new System.NotImplementedException();
        }

        Policydetails IClaim.GetPolicydetails(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}