using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            int sum = num1 + num2;
        
            Console.WriteLine(sum);
        }
    }
}
