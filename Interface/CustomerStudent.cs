using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class CustomerStudent : ICustomer
    {
        string name { get; set; }
        public string Name { get => name; set => name = value; }

        public void Foo() //We must implement all members of an interface except its default methods
        {
            Console.WriteLine("Salam");
        }
    }
}
