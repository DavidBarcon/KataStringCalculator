using System.Globalization;
using System.Runtime.CompilerServices;

namespace StringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCalculatorAdder stringC = new StringCalculatorAdder();

            if (args.Length == 1)
            {
                int res = stringC.add(args[0]);
                Console.WriteLine(res);

            }
            else if (args.Length > 1)
            {
                Console.WriteLine("Exactly one argument is allowed.");
            }
        }
    }
}
