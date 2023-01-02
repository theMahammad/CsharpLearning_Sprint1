using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Address
    {
        public string AddressType { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        
        public void ShowAdressDetails()
        {
            Console.WriteLine("Address Type : {0} " +
                "City : {1} " +
                "Street : {2} " +
                "Post Code : {3} ",AddressType,City,Street,PostCode);
        }
    }
}
