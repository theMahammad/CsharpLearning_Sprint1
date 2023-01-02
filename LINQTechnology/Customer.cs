using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTechnology
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


        public void PrintShortInfo()
        {
            Console.WriteLine($"Full Name : {Name} {Surname} | Age : {DateTime.Now.Year-Birthday.Year} | Country : {Country} ");
        }
    }
}
