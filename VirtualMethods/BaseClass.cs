using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class BaseClass
    {
        public virtual void sayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
