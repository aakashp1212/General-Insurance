using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using System.Linq;

namespace GeneralInsuranceFinal.DataAccessLayer
{
    public class logindoa : Interfacelogin { 

                private General_InsuranceDatabaseContext db;


    public logindoa(General_InsuranceDatabaseContext _db) => db = _db;

    
        public bool Login(CustomerRegistration customerdata)
        {
            bool status ;
            var User = db.CustomerRegistration;
            status = User.Any(user => user.Email == customerdata.Email && user.Password == customerdata.Password);
            return status;
        
        }
    }
}
