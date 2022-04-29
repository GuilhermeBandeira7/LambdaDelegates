using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Course.Entities
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name.ToUpper() + " , "+ Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product other) // IComparable implementation comparing two product's names
        {
            return Name.CompareTo(other.Name);
            //return Price.CompareTo(other.Price); comparing price 
        }
    }
}
