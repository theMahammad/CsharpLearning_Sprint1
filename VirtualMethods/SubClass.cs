using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class SubClass:BaseClass
    {
        public override void sayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}
