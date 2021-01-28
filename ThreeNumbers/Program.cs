using System;

namespace ThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;

            int average = sum / 3;

            Console.WriteLine($"The sum of your numbers is: {sum}");

            Console.WriteLine($"The average of your numbers is: {average}");
        }
    }
}
