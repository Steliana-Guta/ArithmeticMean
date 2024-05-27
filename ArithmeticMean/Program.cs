using System;

namespace ArithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We'll be calculating the sum and the mean of the following array of numbers : 3.4, 6.7, 8.3, 9.0, 2.4.");

            double[] array = new double[] { 3.4, 6.7, 8.3, 9.0, 2.4 };
            double sum = 0;
            double mean = 0;
            Console.WriteLine("We're starting from zero, adding each number one by one.");
            for (int index = 0; index < array.Length; index++ )
            {
                sum += array[index];
                Console.WriteLine("After we added the number we are left with :" + sum);
            }

            mean = sum / array.Length;
            Console.WriteLine("So the mean of the array is : " + mean);

            Console.ReadLine();
         
        }
    }
}
