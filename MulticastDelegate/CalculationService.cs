using System;
namespace Course.Services
{
    class CalculationService
    {
        public static void ShowMax(double x, double y) // higher number between two integers
        {
            //condition ? consequent : alternative
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }
        public static void ShowSum(double x, double y) // sum of two integers
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}