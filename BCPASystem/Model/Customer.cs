using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCPASystem
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return String.Format(FirstName, LastName, AddressLine1, AddressLine2, Postcode, City, MobileNumber, Email);
        }
    }
}
