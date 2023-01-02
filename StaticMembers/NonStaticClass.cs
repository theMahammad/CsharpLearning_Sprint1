using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class NonStaticClass //A non-static class has also static constuctor. It works on background by default
    {
        private static int staticCtorCount = 0;
        private static int nonStaticCtorCount = 0;
        static NonStaticClass() // Static constructor works once 
        {
            staticCtorCount++;
            Console.WriteLine("I'm worked + Using static CTOR : {0}",staticCtorCount);
        }
        public NonStaticClass() // Whenever we create an instance of this class, non-static constructor will work.
        {
            nonStaticCtorCount++;
            Console.WriteLine("I'm worked + Using non-static CTOR : {0}",nonStaticCtorCount);
        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello world");
        }

    }
}
