using GeneralInsuranceFinal.Models;

namespace GeneralInsuranceFinal.DataAccessLayer
{
    internal class login : Login
    {
        public object email { get; set; }
        public object password { get; set; }
    }
}