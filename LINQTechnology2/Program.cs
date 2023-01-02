using LINQTechnology;

namespace LINQTechnology2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSource ds = new();
            List<Customer> customers = ds.customerList();

            #region Get elements in list by a custom condition
            //Way 1
            var list = customers.Where(x => x.Name.StartsWith('A')).ToList();

            //Way 2
            var list1 = (from x in customers //Declaring variable for iteration
                        where x.Name.StartsWith('A') //Condition
                        select x)//Get elements which meet the above condition
                        .ToList(); 
            


            #endregion
        }
    }
}