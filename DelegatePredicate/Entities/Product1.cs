using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Course.Entities
{
    public class Product1
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product1(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name.ToUpper() + " , "+ Price.ToString("F2", CultureInfo.InvariantCulture);
        }

       
    }
}
