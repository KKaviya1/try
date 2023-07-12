using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2, result;
                Console.WriteLine("enter first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine($"result after dividing {num1} by {num2} is = \t {result}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("error!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
