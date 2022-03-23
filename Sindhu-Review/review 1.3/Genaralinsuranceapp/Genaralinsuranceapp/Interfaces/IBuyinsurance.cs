
using Genaralinsuranceapp.Repository;
using System.Collections.Generic;

namespace Genaralinsuranceapp.Interfaces
    
{
    public interface IBuyinsurance
    {

       
        int AddInsurance(Vehiclesdetails vehiclesdetails);

        List<Vehicletypes> GetVehicletypes();
        
        Vehiclesdetails GetInsuranceById(int id);

        List<Insuranceplantype> GetPlans();

        List<Insuranceduration> GetDuration();

        List<Vehiclesdetails> GetAllVehicles();

    }

   
}
