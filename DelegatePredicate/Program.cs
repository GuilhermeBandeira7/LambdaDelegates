using Course.Entities;
using System;

namespace DelegatePredicate // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //Predicate Delegate = Representa um método que recebe um objeto do tipo T e retorna um valor booleano
        
        static void Main(string[] args)
        {
            List<Product1> list = new List<Product1>();
            list.Add(new Product1("Tv", 900.00));
            list.Add(new Product1("Mouse", 50.00));
            list.Add(new Product1("Tablet", 350.50));
            list.Add(new Product1("HD Case", 80.90));

            // => tal que
            //list.RemoveAll(p => p.Price > 100.0);
            list.RemoveAll(ProductTest); //RemoveAll accepts a predicate delegate returning a boolean
            foreach(Product1 p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product1 product)
        {
            return product.Price >= 100.0; // returning only products above 100 
        }

    }
}
