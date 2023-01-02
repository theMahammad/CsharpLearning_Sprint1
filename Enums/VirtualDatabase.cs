using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public static class VirtualDatabase
    {
        static List<Customer> customers = new List<Customer>();

        public static CustomerReturnValue AddNewCustomer(Customer customer)
        {
             
            customers.Add(customer);
            return CustomerReturnValue.succesfullyAdding;
        }
    }
}
