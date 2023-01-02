
using LINQTechnology;
using System.Collections.Immutable;

namespace LINQTechnology3

{
    public class Program
    {
        static void Seperate()
        {
            Console.WriteLine("******************************");
        }
        
        static void Main(string[] args)
        {
            DataSource ds = new DataSource();
            List<Customer> customers = ds.customerList();


            #region Find customers whose country name begins with 'A' 
            //LINQ to method
            var matchedCustomers1_method = customers.Where(x=>x.Country.StartsWith('A')).ToList();
            IterateSelectedList(matchedCustomers1_method);
            Seperate();
            var matchedCustomers1_query = (from x in customers where x.Country.StartsWith('A') select x).ToList();
            IterateSelectedList(matchedCustomers1_query);
            #endregion

            Seperate();
            #region Find customers which meets the conditions that Customer's name value must contains 'b' and his country value must contains 'a'
            var matchedCustomers2_query = (from x in customers where x.Country.Contains('a') && x.Name.Contains('b') select x).ToList();
            IterateSelectedList(matchedCustomers2_query);
            Seperate();
            var matchedCustomers2_method = customers.Where(x => x.Country.Contains('a') && x.Name.Contains('b')).ToList();
            IterateSelectedList(matchedCustomers2_method);
            #endregion

            Seperate();
            #region Find customers whose year of birth is bigger than 1990 and name contains 'a' 

            var matchedCustomers3_method = customers.Where(x => x.Birthday.Year > 1990 && x.Name.Contains('a')).ToList();
            
            IterateSelectedList(matchedCustomers3_method);
            Seperate();
            var matchedCustomers3_query = (from x in customers
                                           where x.Birthday.Year > 1990 && x.Name.Contains('a')
                                           select x).ToList();
            IterateSelectedList(matchedCustomers3_query);
            #endregion 
            Seperate();
            #region Find customers whose year of birth is bigger than 1990 or name contains 'a' 
            var matchedCustomers4_method = customers.Where(x=> x.Birthday.Year>1990 || x.Name.Contains('a')).ToList();
            IterateSelectedList(matchedCustomers4_method);
            Seperate();
            var matchedCustomers4_query = (from x in customers
                                           where x.Birthday.Year > 1990 || x.Name.Contains('a')
                                           select x).ToList();
            IterateSelectedList(matchedCustomers4_query);

            #endregion
            Seperate();
            
        
        }

        public static void IterateSelectedList(List<Customer> matchedCustomers)
        {
            foreach(var item in matchedCustomers)
            {
                item.PrintShortInfo();
            }
        }

    }
}