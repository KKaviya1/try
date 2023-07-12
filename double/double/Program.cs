using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            Console.WriteLine("enter first number");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("enter second number");
            double.TryParse(Console.ReadLine(), out num2);
            result = num1 / num2;
            Console.WriteLine($"result after dividing {num1} by {num2} is = \t {result}");
            Console.ReadKey();

        }
    }
}
