using System;

namespace Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number that you would like to round: ");
            double num = double.Parse(Console.ReadLine());
            int roundedNum = (int)Math.Round(num, MidpointRounding.AwayFromZero);

            Console.WriteLine(roundedNum);
        }
    }
}
