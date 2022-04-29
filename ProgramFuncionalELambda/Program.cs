using System;
namespace Course
{
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect); // ex of functinal programming, using a function to change odd values
            Console.WriteLine(string.Join(" ", vect)); //string.Join gets all the elements of the vector(vect) and put them into a single string separated by spaces
        }
        public static void ChangeOddValues(int[] numbers) // odd values method receiving an int array
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0) // if it's not an even value
                {
                    numbers[i] += globalValue; //array at i postion + globalValue(3)
                }
            }
        }
    }
}
