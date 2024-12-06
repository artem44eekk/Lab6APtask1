using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб6АтаП
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); // Handle negative numbers
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers:");

            // Read three numbers from the user
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            // Calculate the sum of digits for each number
            int sum1 = SumOfDigits(number1);
            int sum2 = SumOfDigits(number2);
            int sum3 = SumOfDigits(number3);

            // Output the results
            Console.WriteLine($"\nThe sum of digits of {number1} is: {sum1}");
            Console.WriteLine($"The sum of digits of {number2} is: {sum2}");
            Console.WriteLine($"The sum of digits of {number3} is: {sum3}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
