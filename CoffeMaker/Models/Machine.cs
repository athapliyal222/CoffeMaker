using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMaker.Models
{
    public class Machine
    {
        public Outlets outlets { get; set; }
        public TotalItemsQuantity total_items_quantity { get; set; }
        public Beverages beverages { get; set; }
    }
}
