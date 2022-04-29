using System;

namespace ActionDelegate // Note: actual namespace depends on the project name.
{
    //Action Delegate Representa um método void que recebe zero ou mais argumentos
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> action = UpdatePrice; // Action delegate pointing to UpdatePrice

            //Below we're using a lambda expression to make the logic of UpdatePrice method
            Action<Product> action2 = p => { p.Price += p.Price * 0.1; }; //curly brackets means a void method

            list.ForEach(action2); //ForEach list method has the Action Delegate as ovorload
            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
        }

        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.1; //update price in 10%
        }
    }
}
