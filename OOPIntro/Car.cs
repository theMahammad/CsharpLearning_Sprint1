using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    internal class Car
    {
        
        public string Brand { get; set; }
        public string Model { get; set;  }
        public int ModelYear { get; set; }
        
        public decimal UsingByKm { get; set; }
        public int FuelType { get; set; }
        public decimal? Price { get; set; }
        public decimal SalePrice { get; set; }
        public decimal MaxDiscountAmount { get; set; }
        
        public Car()
        {

        }
        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand,string model,int modelYear):this(brand,model)
        {
           
            ModelYear = modelYear;
        }
        public Car(string brand, string model, int modelYear, long usingByKm):this(brand,model,modelYear)
        {
            UsingByKm = usingByKm;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Brand : {Brand} | Model : {Model} | ModelYear : {ModelYear} | " +
                $"Using by kilometers : {UsingByKm} | Price : {Price} | Fuel type : {FuelType}");
        }
        public void SetPrice(decimal price)
        {
            decimal minPrice = SalePrice - MaxDiscountAmount;
            if(price >= minPrice)
            {
                Price = minPrice;
                Console.WriteLine("Price has been set");
            }
            else
            {
                Console.WriteLine("This price is lower than minimum considered price");
            }
        }
    }
}
