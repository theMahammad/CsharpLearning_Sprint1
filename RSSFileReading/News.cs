using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSFileReading

{
    public class News
    {
        public string Headline { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Headline;
        }
    }
}
