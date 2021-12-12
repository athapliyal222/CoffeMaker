using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CoffeMaker.Models;
using CoffeMaker.Controllers;
using System.IO;

namespace CoffeMaker
{
    public class Program
    {
        public static void Main(string[] args)  //can be used to make the beverages
        {
            StreamReader r = new StreamReader("test.json");
            
                string json = r.ReadToEnd();
                
                Root m = JsonConvert.DeserializeObject<Root>(json);
                
                HotTea b = new HotTea(m.machine.beverages.hot_tea.hot_water, m.machine.beverages.hot_tea.hot_milk, m.machine.beverages.hot_tea.ginger_syrup, m.machine.beverages.hot_tea.sugar_syrup, m.machine.beverages.hot_tea.tea_leaves_syrup);
                HotCoffee c = new HotCoffee(m.machine.beverages.hot_coffee.hot_water, m.machine.beverages.hot_coffee.ginger_syrup, m.machine.beverages.hot_coffee.hot_milk, m.machine.beverages.hot_coffee.sugar_syrup, m.machine.beverages.hot_coffee.tea_leaves_syrup);
                GreenTea g = new GreenTea(m.machine.beverages.green_tea.hot_water, m.machine.beverages.green_tea.ginger_syrup, m.machine.beverages.green_tea.sugar_syrup, m.machine.beverages.green_tea.green_mixture);
                BlackTea bl = new BlackTea(m.machine.beverages.black_tea.hot_water, m.machine.beverages.black_tea.ginger_syrup, m.machine.beverages.black_tea.sugar_syrup, m.machine.beverages.black_tea.tea_leaves_syrup);
                TotalItemsQuantity t = new TotalItemsQuantity(m.machine.total_items_quantity.hot_water, m.machine.total_items_quantity.hot_milk, m.machine.total_items_quantity.ginger_syrup, m.machine.total_items_quantity.sugar_syrup,m.machine.total_items_quantity.tea_leaves_syrup);
            
            if (t.hot_water >= c.hot_water && t.ginger_syrup >= c.ginger_syrup && t.hot_milk >= c.hot_milk && t.sugar_syrup >= c.sugar_syrup && t.tea_leaves_syrup >= c.tea_leaves_syrup)
            {
                Console.WriteLine("Coffee Prepared!");
                t.hot_water = t.hot_water - c.hot_water;
                t.ginger_syrup = t.ginger_syrup - c.ginger_syrup;
                t.hot_milk = t.hot_milk - c.hot_milk;
                t.sugar_syrup = t.sugar_syrup - c.sugar_syrup;
                t.tea_leaves_syrup = t.tea_leaves_syrup - c.tea_leaves_syrup;

            }
            else { Console.WriteLine("Coffee Cannot Be Prepared!"); }


            if (t.hot_water >= b.hot_water && t.ginger_syrup >= b.ginger_syrup && t.hot_milk >= b.hot_milk && t.sugar_syrup >= b.sugar_syrup && t.tea_leaves_syrup >= b.tea_leaves_syrup)
            {
                Console.WriteLine("Hot Tea Prepared!");
                t.hot_water = t.hot_water - b.hot_water;
                t.ginger_syrup = t.ginger_syrup - b.ginger_syrup;
                t.hot_milk = t.hot_milk - b.hot_milk;
                t.sugar_syrup = t.sugar_syrup - b.sugar_syrup;
                t.tea_leaves_syrup = t.tea_leaves_syrup - b.tea_leaves_syrup;

            }
            else { Console.WriteLine("Hot Tea Cannot Be Prepared!"); }


            if (t.hot_water >= bl.hot_water && t.ginger_syrup >= bl.ginger_syrup && t.sugar_syrup >= bl.sugar_syrup && t.tea_leaves_syrup == bl.tea_leaves_syrup)
            {
                Console.WriteLine("Black Tea Prepared!");
                t.hot_water = t.hot_water - bl.hot_water;
                t.ginger_syrup = t.ginger_syrup - bl.ginger_syrup;
                t.sugar_syrup = t.sugar_syrup - bl.sugar_syrup;
                t.tea_leaves_syrup = t.tea_leaves_syrup - bl.tea_leaves_syrup;

            }
            else { Console.WriteLine("Black Tea Cannot Be Prepared!"); }

            if (t.hot_water >= g.hot_water && t.ginger_syrup >= g.ginger_syrup && t.sugar_syrup >= g.sugar_syrup)
            {
                Console.WriteLine("Green Tea Prepared!");
                t.hot_water = t.hot_water - g.hot_water;
                t.ginger_syrup = t.ginger_syrup - g.ginger_syrup; ;
                t.sugar_syrup = t.sugar_syrup - g.sugar_syrup;

            }
            else { Console.WriteLine("Green Tea Cannot Be Prepared!"); }

            
            CreateHostBuilder(args).Build().Run();

           

        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        
    }
}
