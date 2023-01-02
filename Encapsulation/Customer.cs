using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Customer

    {
        public Customer()
        {
            customerCode = GenerateCustomerCode();
            
        }
        //Fields
        private int id;
        private string name;
        private string surname;
        private string customerCode;
        private string pin;
        private string emailAdress;

        //Properties
        public int Id {
            get { return id; }
            set {
                if (value >0){
                    id = value;
                }
                else
                {
                    Console.WriteLine("Id can't be set");
                }
                }


        }
        public string Name
        {
            get
            {
                if(name.Length % 2 == 0)
                {
                    return name.Substring(0, name.Length / 2); // Return the half of this name
                }
                else
                {
                    return name;
                }
            }
            set
            {
                name = value;
            }
        }
        public string Surname {
            get { return surname; }
            set
            {
                surname = value;
                this.emailAdress = $"{name.ToLower()}.{surname.ToLower()}@gmail.com";
            }
        
        }

        public string CustomerCode
        {

            get { return customerCode; }
            private set { customerCode = value; } //Other classes doesn't set a value with this property
        }

        public string Pin
        {
             get { return pin.Substring(0,3) +"********"; }
            set
            {
                if (value.Length == 11)
                {
                    bool isDigitAllChars = value.All(c => Char.IsDigit(c)); //Checking all members of the given value
                    if (isDigitAllChars)
                    {
                        pin = value;
                    }
                    else
                    {
                        Console.WriteLine("All symbols must be a digit");
                        pin = "00000000000";
                    }
                }
                else
                {
                    Console.WriteLine("Total length of the pin must be eleven");
                    pin = "00000000000";
                }
            }
        }

        public string EmailAdress { get { return emailAdress; } private set { emailAdress = value; } }
        private string GenerateCustomerCode()
        {
            Random rnd = new();
            return rnd.Next(5000, 15000).ToString();
        }


    }
}
