using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class Insuranceplantype
    {
        public Insuranceplantype()
        {
            Policydetails = new HashSet<Policydetails>();
        }

        public string Planname { get; set; }
        public int PlanId { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
    }
}
