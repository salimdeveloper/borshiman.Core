using System.Net;
using System;

namespace Borshiman.Core.Models
{
    public class Anglers
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PlayingHand { get; set; }
        public Address Address { get; set; }
        public long MobileNo { get; set; }
        public bool MobileVerified { get; set; }
        public string Email { get; set; }

    }
    public class Address
    {
        public string City { get; set; }
        public int PinCode { get; set; }
    }
}
