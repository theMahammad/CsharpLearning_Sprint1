using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Staff:BaseType
    {
        public DateTime WorkBeginTime { get; set; }
        public DateTime WorkEndTime { get; set; }
        public Student Student { get; set; }
     
     
    }
}
