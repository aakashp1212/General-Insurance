namespace GeneralInsuranceFinal.DataAccessLayer
{
    public class Claiminsurancedao
    {
        public class ClaiminsuranceDataAccess : IClaiminsurance
        {

            private generalinsuranceContext db;


            public ClaiminsuranceDataAccess(generalinsuranceContext _db)
            {
                db = _db;
            }
            public int AddClaimdetails(Claimdata claimdata)
            {
                db.Claimdata.Add(claimdata);
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
}
