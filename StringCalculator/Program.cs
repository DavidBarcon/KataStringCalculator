using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace StringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (validation(args))
            {
                StringCalculatorParser parser = new StringCalculatorParser();
                StringCalculator stringCalculator = new StringCalculator(parser);
                Console.WriteLine(stringCalculator.add(args[0]));
            }
            
        }

        private static bool validation(string[] args)
        {
            if (args.Length == 1)
            {
                if (args[0].GetType() == typeof(string))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Argument must be a string");
                    return false;
                }

            }
            else
            {
                Console.WriteLine("Exactly one argument is allowed.");
                return false;
            }
        }
    }
}
