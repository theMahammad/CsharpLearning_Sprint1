using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass.Staff
{
    public partial class Staff
    {
        public void AddStaff()
        {
            Console.WriteLine($"{this.Id}");
            Console.WriteLine("New staff has been added");
        }
        public void DeleteStaff(Staff s)
        {
            Console.WriteLine("Selected staff has been deleted");
        }
    }
}
