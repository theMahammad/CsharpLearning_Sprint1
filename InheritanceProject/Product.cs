using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public class Product
    {
        private int id;
        private string barcode;
        private static int elementCount = 1;

        public int Id
        {
            get { return id; }
            private set
            {
                this.id = value;
            }
        }
        public string Barcode { 
            get { return barcode; }
            set
            {
                bool barcodeRepetition = false;
                var DB = VirtualDatabase.GetProducts();
                foreach(Product product in DB)
                {
                    if (product.barcode == value)
                    {

                        barcodeRepetition = true;
                        break;
                    }
                }
                if (barcodeRepetition)
                {
                    Console.WriteLine("Please enter another barcode. This also exists in system");
                }
                else
                {
                    this.barcode = value;
                }
            }
        }
        public string Name { get; set; }
        
        private decimal purchasePrice;
        private decimal salePrice;
        private decimal campaignPrice;
        public decimal PurchasePrice {
            get { return purchasePrice; }
            set
            {
                if (value >=0)
                {
                purchasePrice = value;  
                }  
            }
        }
        public decimal SalePrice {
            get { return salePrice; }
            set
            {
                if(value >= purchasePrice)
                {
                    salePrice = value;
                }
            }
        }
        public decimal CampaignPrice {
            get { return campaignPrice; }
            set
            { 
                if (value >= 0 && value<SalePrice)
                {
                    campaignPrice = value;
                }
            } 
        }
        public Product()
        {
            this.id = elementCount++;
        }


        
    }
}
