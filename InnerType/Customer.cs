using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Customer
    {
        #region Normal Fields
        public int Id { get; set; }
        public string PIN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        #endregion
        #region Fields With InnerType
        public List<Address> adresses;
        public List<Contact> contacts;
        public List<Order> orders;

        #endregion
        public Customer()
        {
            adresses = new List<Address>();
            contacts = new List<Contact>(); 
            orders = new List<Order>(); 
        }
    }
}
