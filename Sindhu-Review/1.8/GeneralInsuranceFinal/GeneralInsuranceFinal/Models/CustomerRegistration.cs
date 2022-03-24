using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class CustomerRegistration
    {
        public CustomerRegistration()
        {
            Login = new HashSet<Login>();
            Policydetails = new HashSet<Policydetails>();
            Vehiclesdetails = new HashSet<Vehiclesdetails>();
        }

        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public int? UserId { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Policydetails> Policydetails { get; set; }
        public virtual ICollection<Vehiclesdetails> Vehiclesdetails { get; set; }
    }
}
