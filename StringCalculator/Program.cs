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
            //copy string and replace \n by ,
            string nums = (string)numbers.Clone();
            nums = nums.Replace("\n", ",");

            //divide the sring and sum its elements
            string[] values = nums.Split(',');
            int sum = 0;
            foreach (string value in values)
            {
                sum += Int32.Parse(value);
            }

            return sum;
        }
    }
}