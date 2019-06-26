using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_Core.Domain
{
    public class OrderItem
    {
        public int OrderId { get; set; }

        public Product Product { get; set; }

        public int NumberOfItems { get; set; }
    }
}
