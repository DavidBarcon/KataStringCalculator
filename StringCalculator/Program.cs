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
            string[] values = numbers.Split(',');
            int sum = 0;
            foreach (string value in values)
            {
                sum += Int32.Parse(value);
            }

            return sum;
        }
    }
}