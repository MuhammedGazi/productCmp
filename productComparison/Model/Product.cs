﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productComparison.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        public int CompanyId { get; set; }
    }
}
