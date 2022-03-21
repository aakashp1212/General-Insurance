using System.Collections.Generic;

namespace Genaralinsuranceapp.BusinessLayer
{
    public class Vehicletypes
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
