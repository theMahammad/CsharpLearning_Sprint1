using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQTechnology;

namespace LINQTechnology4
{
    public static class Helper
    {
        public static void IterateSelectedList(List<Customer> matchedCustomers)
        {
            if (matchedCustomers.Count > 0)
            {
                foreach (var item in matchedCustomers)
                {
                    item.PrintShortInfo();
                }
            }
            else
            {
                Console.WriteLine("There is no one who meets given conditions");
            }
            
        }
        public static void Seperate()
        {
            Console.WriteLine("*******************************");
        }
    }
}
