using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    Console.WriteLine("Parsed number using intTryParse is: \t " + result);
                }
                else
                {
                    Console.WriteLine("Failed to Parse");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
