using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MyException:Exception
    {

        public override string Message => "You can't write a number bigger than 10 at this system";
    }
}
