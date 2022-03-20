using Genaralinsuranceapp.BusinessLayer;

namespace Genaralinsuranceapp.Interfaces
{
    public interface IBuyinsurance
    {
        int AddInsurance(vehiclemodels vehiclesdetails);


        vehiclemodels GetInsurance(int id);


    }
}
