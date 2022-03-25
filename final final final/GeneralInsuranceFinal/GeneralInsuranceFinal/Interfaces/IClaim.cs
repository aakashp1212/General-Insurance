using GeneralInsuranceFinal.Models;
using System.Collections.Generic;

namespace GeneralInsuranceFinal.Interfaces
{
    public interface IClaim
    {
        Policydetails GetPolicydetails(int id);

        List<Claimreasons> Getclaimreasons();

        int AddClaimdetails(Claimhistory claimdata);


    
    }
}
