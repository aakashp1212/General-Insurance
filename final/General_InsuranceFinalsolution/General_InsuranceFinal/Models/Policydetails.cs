using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace General_InsuranceFinal.Models
{
    public partial class Policydetails
    {
        public Policydetails()
        {
            Claimhistory = new HashSet<Claimhistory>();
        }

        public int PolicyNumber { get; set; }
        public int? DurationId { get; set; }
        public int? PlanId { get; set; }
        public int? CustomerId { get; set; }
        public int? VehicletypeId { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Insuranceduration Duration { get; set; }
        public virtual Insuranceplantype Plan { get; set; }
        public virtual Vehicletypes Vehicletype { get; set; }
        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
    }
}
