using System.Collections.Generic;
using static Genaralinsuranceapp.BusinessLayer.claimhistory;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class Policydetails
    {
        public Policydetails()
        {
            Claimhistory = new HashSet<Claimhistory>();
            Vehiclesdetails = new HashSet<vehiclemodels>();
        }

        public int PolicyNumber { get; set; }
        public int? DurationId { get; set; }
        public int? PlanId { get; set; }
        public long? CustomerId { get; set; }
        public int? VehicletypeId { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Insuranceduration Duration { get; set; }
        public virtual Insuranceplantype Plan { get; set; }
        public virtual Vehicletypes Vehicletype { get; set; }
        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
        public virtual ICollection<vehiclemodels> Vehiclesdetails { get; set; }
    }
}
