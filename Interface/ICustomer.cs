using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ICustomer
    {
        #region Fields
        //public string name;   -- we cannot set a field in Interface
        #endregion
        #region Properties
        public string Name { get; set; }
        #endregion
        #region Methods 
        public void Foo();
        public void Test() //We can set default methods, but they are not inherited from derived class
        {
            Console.WriteLine("salam");
        }
        #endregion
    }
}
