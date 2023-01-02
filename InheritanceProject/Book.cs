﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    public sealed class Book:Product
    {
        public int TotalPages { get; set; }
        public string Genre { get; set; }
        public string AuthorName { get; set; }
    }
}
