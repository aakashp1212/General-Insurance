using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class Insuranceduration
    {
        public Insuranceduration()
        {
            Policydetails = new HashSet<Policydetails>();
        }

        public string DurationValue { get; set; }
        public int DurationId { get; set; }

        public virtual ICollection<Policydetails> Policydetails { get; set; }
    }
}
