using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Staff
{
    public partial class Staff //We can divide our class members into multiple parts by using "partial" keyword 
    {
        public int Id   { get; set; }
        public string Name { get; set; }
        
    }
}
