using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMaker.Models
{
    public class Beverages
    {
        public HotTea hot_tea { get; set; }
        public HotCoffee hot_coffee { get; set; }
        public BlackTea black_tea { get; set; }
        public GreenTea green_tea { get; set; }

        public Beverages(HotTea hot_tea, HotCoffee hot_coffee, BlackTea black_tea, GreenTea green_tea)
        {
            this.black_tea = black_tea;
            this.hot_coffee = hot_coffee;
            this.black_tea = black_tea;
            this.green_tea = green_tea;
        }
        
    }
}
