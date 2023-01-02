using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal static class Helper
    {
        public static void SendEmail(string receiverEmailAdress,string subject, string message)
        {
            //Email sending operations......
            Console.WriteLine("The message has been sent to {0}",receiverEmailAdress);
        }

        /*public void HelloWorld() // Static classes can only contains static members(fields,methods)
        {
            Console.WriteLine("Hello");
        }
    */
       // public static Helper(){} //compile-time error -- The access modifier of a static constructor must be private
        
        static Helper() //Static constructor have worked once during whole program life
        {
            
        }
        
    }
}
