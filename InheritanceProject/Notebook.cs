using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public sealed class Notebook:Product
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public DateTime ProductionYear { get; set; }
    }
}
