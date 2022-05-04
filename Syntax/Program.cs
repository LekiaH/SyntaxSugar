using System;

namespace Syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            var response = (answer < 9);

            if (answer < 9)
            {
                Console.WriteLine($"{answer} is less than 9.");
            }
            else
            {
                Console.WriteLine($"{answer} is greater than 9.");
            }


        }
    }
}
