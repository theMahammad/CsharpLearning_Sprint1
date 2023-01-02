using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class SubClass : AbstractClass
    {
        public override void Test()
        {
            Console.WriteLine("Hello => {0}",this.GetType().Name);
        }
    }
}
