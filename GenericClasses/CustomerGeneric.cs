using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using   System.Threading.Tasks;

namespace GenericClasses
{
    public class CustomerGeneric<T>
    {
         public int Id { get; set; }
         public string Pin { get; set; }
         public string Name { get; set; }
         public string Surname { get; set; }
         public DateTime Birthday { get; set; }
    }
}
