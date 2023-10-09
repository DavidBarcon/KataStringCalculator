using System.Globalization;
using System.Runtime.CompilerServices;

namespace StringCalculator
{
    internal class StringCalculatorMain
    {
        static void Main(string[] args)
        {
            StringCalculatorAdder stringCalculator = new StringCalculatorAdder();

            if (args.Length == 1)
            {
                int res = stringCalculator.add(args[0]);
                Console.WriteLine(res);

            }
            else if (args.Length > 1)
            {
                Console.WriteLine("Exactly one argument is allowed.");
            }
        }
    }
}
