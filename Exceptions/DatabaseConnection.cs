using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class DatabaseConnection
    {
        public static void Open()
        {
            Console.WriteLine("Db connection has been opened");
        }
        public static void Close()
        {
            Console.WriteLine("Db connection has been closed");
        }
    }
}
