using GeneralInsuranceFinal.Models;
using System.Collections.Generic;

namespace GeneralInsuranceFinal.Interfaces
{
    public interface IBuyinsurance
    {
        


            int AddInsurance(Vehiclesdetails vehiclesdetails);

            int AddPolicy(Policydetails policydetails);



            List<Vehicletypes> GetVehicletypes();

            Vehiclesdetails GetInsuranceById(int id);

            List<Insuranceplantype> GetPlans();

            List<Insuranceduration> GetDuration();

        

    }
}
