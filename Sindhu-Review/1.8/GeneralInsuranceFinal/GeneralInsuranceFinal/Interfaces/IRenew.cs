using GeneralInsuranceFinal.Models;
using System.Collections.Generic;

namespace GeneralInsuranceFinal.Interfaces
{
    public interface IRenew
    {

        int Updatepolicy(Policydetails policydetails);

        List<Policydetails> GetAllPolicies();

        CustomerRegistration GetPolicyByEmail(string email);

    }
}
