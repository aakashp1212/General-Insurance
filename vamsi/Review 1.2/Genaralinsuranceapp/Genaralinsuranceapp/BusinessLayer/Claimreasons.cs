using System.Collections.Generic;
using static Genaralinsuranceapp.BusinessLayer.claimhistory;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class Claimreasons
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
