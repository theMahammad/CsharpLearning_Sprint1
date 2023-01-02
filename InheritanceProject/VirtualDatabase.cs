using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public class VirtualDatabase
    {
        private static List<Product> products = new List<Product>();

        public static void AddNewProduct(Product product)
        {
            if (product != null && !(string.IsNullOrEmpty(product.Barcode)))
            {
                products.Add(product);  
            }
        }
      public static List<Product> GetProducts()
        {
            return products;
        }
        public static List<Notebook> GetNotebooks()
        {
            List<Notebook> notebooks = new();
            foreach(Product product in products)
            {
                if(product is Notebook)
                {
                    notebooks.Add((product as Notebook));
                }
            }
            return notebooks;
        }
        public static List<Book> GetBooks()
        {
            List<Book> books = new();
            foreach(Product product in products)
            {
                if(product is Book)
                {
                    books.Add(product as Book); //Unboxing
                }
            }
            return books;
        }
    }
}
