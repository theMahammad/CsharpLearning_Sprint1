using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void SayHelloToSpecificPerson()
        {
            Console.WriteLine(String.Format("Hello our dear student, {0} {1}",Name,Surname));
            SayHelloGenerally(); //While non-static methods can access static method, static methods can't do this operation for non-static methods
        }
        public static void SayHelloGenerally()
        {
            Console.WriteLine("Hello dear students!");
            //SayHelloToSpecificPerson(); //compile-time error
            SayHelloInAzerbaijani(); //Static methods can access only static methods/fields
        }
        private static void SayHelloInAzerbaijani()
        {
           
            Console.WriteLine("Salam, əziz tələbələr");
        }
    }
}
