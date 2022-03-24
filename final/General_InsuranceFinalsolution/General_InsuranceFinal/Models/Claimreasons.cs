using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace General_InsuranceFinal.Models
{
    public partial class Claimreasons
    {
        public Claimreasons()
        {
            Claimhistory = new HashSet<Claimhistory>();
        }

        public string Claimreason { get; set; }
        public int ClaimId { get; set; }

        public virtual ICollection<Claimhistory> Claimhistory { get; set; }
    }
}
