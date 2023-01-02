using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{
    internal class CustomerHelper
    {
        public static void AddCustomer(Customer customer)
        {
            if (customer != null && !(String.IsNullOrEmpty(customer.Username)))
            {


                if (IsUsernameUnique(customer.Username))
                {
                    if (IsEmailUnique(customer.EmailAdress))
                    {
                        int amountOfCustomer = Customer.Customers.Count;
                        customer.Id = amountOfCustomer + 1; // Thanks to this line, we don't need to set Id when create an instance
                        Customer.Customers.Add(customer);
                        Console.WriteLine("The customer  has been added");
                    }
                    else
                    {
                        Console.WriteLine("The given email address already exists in system. Please, try another email adress");
                    }
                    
                }
                else
                {
                    Console.WriteLine("This username already exists in our system. Please try another username");
                }
            }
            else
            {
                Console.WriteLine("Please, add a username for registration");
            }
            
        }
        public static  List<Customer> GetAllCustomers() {
            return Customer.Customers;
        }
        public static void ShowAllCustomers()
        {
            List<Customer> customers = Customer.Customers;
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Id - {0} | Name - {1} | Surname - {2} |" +
                    " EmailAdress - {3} | Username - {4}  | Password - {5}",customer.Id,customer.Name,customer.Surname,customer.EmailAdress,customer.Username,customer.Password);
                Console.WriteLine("**************************");
            
            }
        }
        private static bool IsUsernameUnique(string username)
        {
            var customers = Customer.Customers;
            foreach(Customer customer in customers)
            {
                if (customer.Username == username)
                {
                    return false;

                }
            }
            return true;
        }
        private static bool IsEmailUnique(string emailAdress)
        {
            var customers = Customer.Customers;
            foreach(Customer customer in customers)
            {
                if (customer.EmailAdress == emailAdress)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
