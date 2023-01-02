using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro
{
    internal class Test
    {
        public int number { get; set; }
        public double db { get; set; }
        public char character { get; set;  }
        public  Test()
        {
            number = 7;
        }
        public void AddByOne(ref int number)
        {
            number++;
        }
         
        
    }
}
