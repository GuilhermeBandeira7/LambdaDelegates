using Delegate;

namespace Course
{
    //delegate declaration
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum; is an alternative syntax to the delegate below
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum); 
            // the square method can´t be used with delegate because it hasn't the same delegate signature(parameters)

            // double result = op(a, b);
            double result = op.Invoke(a, b); // invoke is calling the function that is pointing to op variable
            Console.WriteLine(result);
        }
    }
}
