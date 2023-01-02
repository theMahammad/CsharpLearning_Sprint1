using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public sealed class Instructor:Staff //Thanks to the keyword sealed, we can prevent other class to derive from Instructor
    {
        public string Branch { get; set; }
        public int Level { get; set; }
        public Student Student { get; set; }
        void Aue()
        {
           
            
            
        }

    }
}
