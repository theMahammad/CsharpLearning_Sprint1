using Microsoft.VisualBasic.FileIO;

namespace Delegates
{
    internal class Program
    {
        static void Seperate()
        {
            Console.WriteLine("********************************");
        }
        #region Declaring a delegate
        delegate void ArithmeticOperations(double a, double b);
        #endregion

       static void Sum(double a,double b)
        {
            Console.WriteLine($"Sum : {a+b}");
        }
        static void Multiple(double a,double b)
        {
            Console.WriteLine($"Multiplication : {a*b}");
        }
        static void Divide(double a,double b)
        {
            Console.WriteLine($"Division : {a/b}");
        }
        static void Main(string[] args)
        {
            #region Example usage of a delegate 
            ArithmeticOperations AO = new ArithmeticOperations(Sum); // We add a method with same sign of the delegate
            AO += Multiple;
            AO += Divide;
            AO.Invoke(1,5); // This method  runs all methods inside the delegate 'AO'  by adding sequence
            #endregion
            Seperate();
            #region Get methods of a delegate
            Delegate[] methods = AO.GetInvocationList();
            foreach (var item in methods) {
                Console.WriteLine(item.Method.Name);
            }
            #endregion
            Seperate();
            #region Remove a method from the delegate
            AO -= Sum;
            AO.Invoke(1, 5); // It doesn't run the 'Sum' method anymore
            #endregion
            Seperate();
            #region Using delegates with lambda expression

            ArithmeticOperations AO2 = (double a, double b) =>
            {
                Console.WriteLine($"Sum : {a + b}");
            };
            AO2.Invoke(5, 5); //10
            AO2 -= AO2.GetInvocationList().First() as ArithmeticOperations; //We can clear an unnamed method which is added with lambda
            //AO2.Invoke(5, 5); // runtime error -- There isn't any method inside the delegate
            AO2 += (double a,double b) =>
            {
                Console.WriteLine($"Subtraction : {a-b}");
            };
            AO2.Invoke(9, 6); //3
            #endregion

        }
    }
}