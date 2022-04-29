using Course.Entities;
using System;

namespace Course // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Sort method is used to order all the elements in the list
            //We're also comparing two products int the list (p1, p2) using CompareTo

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper())); // using lambda => which is an anonymous function

            //list.Sort(CompareProducts); // passing a function as argument(delegate) to the sort overload Comparison 
          
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static int CompareProducts(Product p1, Product p2) 
        //{
        //    return p1.Name.CompareTo(p2.Name);
        //}

    }
}
