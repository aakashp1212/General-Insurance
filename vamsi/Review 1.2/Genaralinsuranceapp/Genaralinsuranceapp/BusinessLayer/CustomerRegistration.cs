using System;
using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class CustomerRegistration
    {
        public CustomerRegistration()
        {
            Policydetails = new HashSet<Policydetails>();
            Vehiclesdetails = new HashSet<vehiclemodels>();
        }

        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public DateTime? Dob { get; set; }
        public string ContactNo { get; set; }
        public int? PolicyNumber { get; set; }
        public long CustomerId { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
        public virtual ICollection<vehiclemodels> Vehiclesdetails { get; set; }
    }
}
