using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMaker.Models
{
    public class TotalItemsQuantity
    {
        public int hot_water { get; set; }
        public int hot_milk { get; set; }
        public int ginger_syrup { get; set; }
        public int sugar_syrup { get; set; }
        public int tea_leaves_syrup { get; set; }
        public TotalItemsQuantity(int hot_water, int hot_milk, int ginger_syrup, int sugar_syrup, int tea_leaves_syrup)
        {
            this.hot_water = hot_water;
            this.hot_milk = hot_milk;
            this.ginger_syrup = ginger_syrup;
            this.sugar_syrup = sugar_syrup;
            this.tea_leaves_syrup = tea_leaves_syrup;
        }
    }
}
