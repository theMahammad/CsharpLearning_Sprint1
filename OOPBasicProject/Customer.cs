using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicProject
{
    internal class Customer
    {
        #region Virtual Database
        public static List<Customer> Customers;
        #endregion
        #region Static Constructor
        static Customer()
        {
            Customers = new List<Customer>();
        }
        #endregion
        #region Field-Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAdress { get; set; }
        public string Username { get; set; }
        private string password; 
        public string Password
        {
            get { return password.Substring(0,3)+"******"; }
            set
            {
                password = value.Trim();
            }
        }
        #endregion

    }
}
