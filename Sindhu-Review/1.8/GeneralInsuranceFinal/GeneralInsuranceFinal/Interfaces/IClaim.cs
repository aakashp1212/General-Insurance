using GeneralInsuranceFinal.Models;
using System.Collections.Generic;

namespace GeneralInsuranceFinal.Interfaces
{
    public interface IClaim
    {
       
        
            CustomerRegistration GetPolicyByEmail(string email);

            List<Claimreasons> Getclaimreasons();

            int AddClaimdetails(Claimhistory claimdata);
       
    }
}
