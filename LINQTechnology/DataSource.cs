using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTechnology
{
    public class DataSource
    {
        List<Customer> customers;
        public DataSource()
        {
            customers = new List<Customer>();
        }
        public List<Customer> customerList()
        {
            for(int i=1; i <= 100; i++) {
                Customer customer = new Customer()
                {
                    ID = i,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Birthday = FakeData.DateTimeData.GetDatetime(new DateTime(1950, 1, 1), new DateTime(2000, 1, 1)),
                    Country = FakeData.PlaceData.GetCountry(),
                    City = FakeData.PlaceData.GetCity(),
                    PhoneNumber = FakeData.PhoneNumberData.GetPhoneNumber()
                };
                customer.Email = $"{customer.Name.ToLower()}.{customer.Surname.ToLower()}@{FakeData.NetworkData.GetDomain()}";

                customers.Add(customer);
            }
            return customers;
            
        }
    }
}
