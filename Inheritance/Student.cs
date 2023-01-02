using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public sealed class Student:BaseType
    {
        public string Department { get; set; }
        public int Level { get; set; }
        public Student()
        {
            this.Id = 5;
            
        }

    }
}
