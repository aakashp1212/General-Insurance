

using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.DataAcessLayer
{
    public class RenewDataAccess : IRenew
    {


        private generalinsuranceContext db;


        public RenewDataAccess(generalinsuranceContext _db)
        {
            db = _db;
        }

        public int Updatepolicy(Policydetails policydetails)
        {
            
        }
    }
}
