using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class Vehicletypes
    {
        public Vehicletypes()
        {
            Policydetails = new HashSet<Policydetails>();
        }

        public string Vehicletype { get; set; }
        public int VehicletypeId { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
    }
}
