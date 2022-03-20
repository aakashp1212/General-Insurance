using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Genaralinsuranceapp.Repository
{
    public partial class CustomerRegistration
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public long? ContactNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
