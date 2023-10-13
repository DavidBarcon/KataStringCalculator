using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace StringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StringCalculatorParser parser = new StringCalculatorParser();
            StringCalculator stringCalculator = new StringCalculator(parser);
            Console.WriteLine(stringCalculator.add(args[0]));
            
            
        }
    }
}
