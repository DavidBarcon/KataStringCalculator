using System.Globalization;

namespace StringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class StringCalculatorClass
    {
        public StringCalculatorClass() { }

        public int add(String numbers)
        {
            char separator = ',';
            //copy the string to modify it
            string nums = (string)numbers.Clone();

            //get the separator if specified
            if (numbers.Contains("//"))
            {
                separator = numbers[2];
                nums = nums.Substring(3);
            }

            //replace \n by the separator
            nums = nums.Replace("\n", separator.ToString());

            //divide the sring and sum its elements
            string[] values = nums.Split(separator);
            int sum = 0;
            foreach (string value in values)
            {
                sum += Int32.Parse(value);
            }

            return sum;
        }
    }
}