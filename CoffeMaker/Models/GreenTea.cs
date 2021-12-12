using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMaker.Models
{
    public class GreenTea
    {
        public int hot_water { get; set; }
        public int ginger_syrup { get; set; }
        public int sugar_syrup { get; set; }
        public int green_mixture { get; set; }

        public GreenTea(int hot_water, int ginger_syrup, int sugar_syrup, int green_mixture)
        {
            this.hot_water = hot_water;
            this.ginger_syrup = ginger_syrup;
            this.sugar_syrup = sugar_syrup;
            this.green_mixture = green_mixture;
        }
    }
}
