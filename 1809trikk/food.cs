using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1809trikk
{
    public class food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public food(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    
    }
}
