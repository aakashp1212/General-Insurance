using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class Policydetails
    {
        public Policydetails()
        {
            Claimhistory = new HashSet<Claimhistory>();
        }

        public int PolicyNumber { get; set; }
        public int? CustomerId { get; set; }
        public string DurationValue { get; set; }
        public string VehicleType { get; set; }
        public string PlanName { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
    }
}
