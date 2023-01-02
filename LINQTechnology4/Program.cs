using LINQTechnology;
using LINQTechnology3;

namespace LINQTechnology4
{
    internal class Program
    {
        static DataSource ds = new();
        static List<Customer> customers = ds.customerList();
        
        static bool StartsWithA(Customer customer)
        {
            if (customer.Name.StartsWith('A'))
                return true;
            return false;
        }
        static void PrintNameAndSurnameOnly(Customer customer) 
        {
            var title = "Mr";
            Console.WriteLine($"Fullname : {title}.{customer.Name} {customer.Surname}");
        }
        static void Main(string[] args)
        {
            #region Usage of Func<> delegate
            //Find customers whose name value starts with 'A'
                //Conventional way 
                    var func_matchedCustomers1 = customers.Where(x=>x.Name.StartsWith('A')).ToList();
                    Helper.IterateSelectedList(func_matchedCustomers1);
            Helper.Seperate();
            //'Where' method requires Func<Customer,bool> delegate, so we can create itself without using lambda expression
                //Mechanic way
                    Func<Customer, bool> customerConditions = new Func<Customer, bool>(StartsWithA);
                    var func_matchedCustomers2 = customers.Where(customerConditions).ToList();
                    Helper.IterateSelectedList(func_matchedCustomers2);
                    Helper.Seperate();
                    //We can also pass directly the method to 'Where' method as an argument 
                    var func_matchedCustomers3 = customers.Where(StartsWithA).ToList();
                    Helper.IterateSelectedList(func_matchedCustomers3);
            Helper.Seperate();
            var func_matchedCustomers4 = customers.Where(delegate (Customer customer) { return customer.Name.StartsWith('A') ? true : false; }).ToList();
            Helper.IterateSelectedList(func_matchedCustomers4);
            Helper.Seperate();
            var func_matchedCustomers5 = customers.Where((Customer customer) => { return customer.Name.StartsWith('A') ? true : false; }).ToList();
            Helper.IterateSelectedList(func_matchedCustomers5);
            Helper.Seperate();
            var func_matchedCustomers6 = customers.Where((customer) => { return customer.Name.StartsWith('A') ? true : false; }).ToList();
            Helper.IterateSelectedList(func_matchedCustomers6);
            Helper.Seperate();
            var func_matchedCustomers7 = customers.Where(customer => customer.Name.StartsWith('A')).ToList();
            Helper.IterateSelectedList(func_matchedCustomers7);
            #endregion
            Helper.Seperate();
            #region Usage of Predicate<> delegate
            //While Predicate<> delegate always returns a bool value, Func<> delegate can returns a value of any type
            var predicate_matchedCustomers1 = customers.FindAll(customer => customer.Name.Contains('b'));
            Helper.IterateSelectedList(predicate_matchedCustomers1);
            
            //The processes after this is the same with above which mentioned in the region "Usage of Func<> delegate"
            #endregion
            Helper.Seperate();
            #region Usage of Action<> delegate
            //Return type of Action<> delegate is void, so it doesn't return anything
            Action<Customer> action = new(PrintNameAndSurnameOnly);
            customers.ForEach(action);
            Helper.Seperate();
            customers.ForEach(customer =>
            {
                var title = "Mr";
                Console.WriteLine($"Fullname {title}.{customer.Name} {customer.Surname}");
            });
            Helper.Seperate();
            #endregion
            Helper.Seperate();
            #region Practice about delegate types
            
            #region Exercise 1
            /*Get customers who meet following conditions  all :
             * 1 - Name value starts with 'A'
             * 2 - Surname value contains 'b'
             * 3 - Year of birth is bigger than 1985
             */
            var ex_matchedCustomers1 = customers.Where(customer => 
            customer.Name.StartsWith('A') 
            &&
            customer.Surname.Contains('b')
            &&
            customer.Birthday.Year>1985
            ).ToList();
            Helper.IterateSelectedList(ex_matchedCustomers1);
            #endregion

            #endregion

        }


    }
}