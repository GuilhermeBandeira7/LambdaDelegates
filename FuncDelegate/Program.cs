using ActionDelegate;
using System;
using System.Linq;

namespace FuncDelegate // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //Func delegate Representa um método que recebe zero ou mais argumentos, e retorna um valor

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //using lambda 
            Func<Product, string> func = p => p.Name.ToUpper();//Func receive a product and turns it into a string

            //using nameupper method
            Func<Product, string> func2 = NameUpper;

            //the logic below is turning a list Product into a list string using NameUpper
            //Select is a linq method that turns a list type into another type
            //Select linq method has a Func delegate as argument so we need to implement the logic of the delegate in a method to pass a parameter to the Select method
            List<string> result = list.Select(func).ToList(); //Select is IEnumerable type that returns a list, that's why we need ToList()

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }
    }
}
