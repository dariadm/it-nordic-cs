using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_Core.Domain
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
