using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GeneralInsuranceFinal.Models
{
    public partial class Vehiclesdetails
    {
        public string Manufacturer { get; set; }
        public int? CustomerId { get; set; }
        public int? VehicleTypeId { get; set; }
        public string Model { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public string EngineNumber { get; set; }
        public string ChassisNumber { get; set; }
        public int? VehicleAge { get; set; }

        public virtual CustomerRegistration Customer { get; set; }
        public virtual Vehicletypes VehicleType { get; set; }
    }
}
