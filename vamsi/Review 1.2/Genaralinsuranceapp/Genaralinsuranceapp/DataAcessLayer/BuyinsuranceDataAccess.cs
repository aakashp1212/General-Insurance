using Genaralinsuranceapp.BusinessLayer;
using Genaralinsuranceapp.Interfaces;
using Genaralinsuranceapp.Repository;

namespace Genaralinsuranceapp.DataAcessLayer
{
    public class BuyinsuranceDataAccess : IBuyinsurance
    {
        private generalinsuranceContext db;


        public BuyinsuranceDataAccess(generalinsuranceContext _db)
        {
            db = _db;
        }

        public int AddInsurance(vehiclemodels vehiclesdetails)
        {
            throw new System.NotImplementedException();
        }

        public vehiclemodels GetInsurance(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
