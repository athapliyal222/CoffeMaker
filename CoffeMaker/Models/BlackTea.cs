using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMaker
{
    public class BlackTea
    {
        public int hot_water { get; set; }
        public int ginger_syrup { get; set; }
        public int sugar_syrup { get; set; }
        public int tea_leaves_syrup { get; set; }

        public BlackTea(int hot_water, int ginger_syrup, int sugar_syrup, int tea_leaves_syrup)
        {
            this.sugar_syrup = sugar_syrup;
            this.tea_leaves_syrup = tea_leaves_syrup;
            this.hot_water = hot_water;
            this.ginger_syrup = ginger_syrup;
        }
    }
}
