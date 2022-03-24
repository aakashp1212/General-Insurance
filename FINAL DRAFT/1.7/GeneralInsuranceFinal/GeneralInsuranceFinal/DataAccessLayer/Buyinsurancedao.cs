using GeneralInsuranceFinal.Interfaces;
using GeneralInsuranceFinal.Models;
using System.Collections.Generic;
using System.Linq;

namespace GeneralInsuranceFinal.DataAccessLayer
{
   
        public class Buyinsurancedao : IBuyinsurance
        {
            private General_InsuranceDatabaseContext db;


            public Buyinsurancedao(General_InsuranceDatabaseContext _db)
            {
                db = _db;
            }


            public int AddInsurance(Vehiclesdetails vehiclesdetails)
            {
                db.Vehiclesdetails.Add(vehiclesdetails);
                return db.SaveChanges();
            }

            public int AddPolicy(Policydetails policydetails)
            {
                db.Policydetails.Add(policydetails);
                return db.SaveChanges();

            }
        public List<Vehiclesdetails> GetAllVehicles()
        {
            return db.Vehiclesdetails.ToList<Vehiclesdetails>();

        }

        public Vehiclesdetails GetInsuranceById(int id)
            {
                return db.Vehiclesdetails.Where(p => p.CustomerId == id).First<Vehiclesdetails>();
            }

            public List<Insuranceplantype> GetPlans()
            {
                List<Insuranceplantype> Plantype = new List<Insuranceplantype>();
                Plantype = (from plan in db.Insuranceplantype select plan).ToList();
                return Plantype;

            }

            public List<Vehicletypes> GetVehicletypes()
            {
                List<Vehicletypes> vehicletype = new List<Vehicletypes>();
                vehicletype = (from plan in db.Vehicletypes select plan).ToList();
                return vehicletype;
            }

            public List<Insuranceduration> GetDuration()
            {
                List<Insuranceduration> year = new List<Insuranceduration>();
                year = (from Duration in db.Insuranceduration select Duration).ToList();
                return year;
            }




        }
    
}
