using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseType
    {
        public int Id { get; set; }
        protected string PIN { get; set; }
        public string ReferenceCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int RegistrationUser { get; set; } 
        public DateTime UpdateDate { get; set; }
        public int UpdateUser { get; set; }
        public bool IsDeleted { get; set; }

        public BaseType()
        {
            this.Id = 7;
        }

        public void Foo()
        {
            Console.WriteLine("BaseType => Foo() method");
         
        }
    }
}
