using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public  class Product
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionYear {get; set; }

        public Product()
        {
            Console.WriteLine("Product Constructor");
        }
        public void ShowProductDetails()
        {
            Console.WriteLine("Name : {0} " +
                "Price : {1} " +
                "Production Year : {2} ", Name, Price, ProductionYear);
        }
    }
}
