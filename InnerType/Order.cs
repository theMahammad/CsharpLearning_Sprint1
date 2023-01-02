using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Order
    {
        public string OrderCode { get; set; }
        public List<Product> products;

        public Order()
        {
            products = new List<Product>();
        }

    }
}
