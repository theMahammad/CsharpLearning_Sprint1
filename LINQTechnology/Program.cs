namespace LINQTechnology
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataSource ds = new();
            List<Customer> customers = ds.customerList();
            //Print the amount of customers whose first character of their name is 'A'
            int FindThroughHardWay()
            {
                int totalAmount = 0;
                foreach(Customer customer in customers)
                {
                    if (customer.Name.StartsWith('A'))
                    {
                        totalAmount++;
                    }
                }
                return totalAmount;
            }
            Console.WriteLine(FindThroughHardWay());
            int FindThroughLINQ()
            {
                int totalAmount= customers.Where(c=>c.Name.StartsWith('A')).Count();
                return totalAmount;
            }
            Console.WriteLine(FindThroughLINQ());

        }
        
    }
}