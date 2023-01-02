using System.Reflection;
using System.Security.Cryptography;
using System.Linq;
#region Loading .dll file
string pathDLL = @"C:\Users\acer\source\repos\CsharpLearning_Sprint1\ReflectionLib\bin\Debug\net6.0\ReflectionLib.dll";
Assembly lib = Assembly.LoadFile(pathDLL);
#endregion
#region Getting types inside .dll
Type[] types = (from t in lib.GetTypes()
                where t.FullName.Split(".").Length == 2
                select t
                 ).ToArray();
#endregion
#region Iterating Types
foreach(Type type in types)
{

    Console.WriteLine($"Base class name : {type.BaseType.Name} | Class name : {type.Name}");
    #region Getting Constructors
    Console.WriteLine(" Constructors");
    ConstructorInfo[] ctors = type.GetConstructors();
    
        foreach(var ctor in ctors)
        {
            Console.WriteLine("  "+ctor.ToString());
        }
    #endregion

    #region Getting Properties
    Console.WriteLine(" Properties");
    PropertyInfo[] properties = type.GetProperties();
    foreach(var property in properties)
    {
        Console.WriteLine($"  Name - {property.Name} | Type : {property.PropertyType} ");
    }
    #endregion
    #region Getting Methods
    Console.WriteLine(" Methods");
    MethodInfo[] methods = type.GetMethods();
    
    foreach(var method in methods)
    {
        Console.WriteLine($"  Name  - {method.Name} ");
    }
    #endregion

}
#endregion

