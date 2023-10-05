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
            bool negFlag = false;
            var negs = new List<int>();

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
                //if there are negative numbers, add them to a list and handle them later
                int valueNum = Int32.Parse(value);
                if (valueNum < 0) {
                    negFlag = true; 
                    negs.Add(valueNum);
                }   

                //ignore numbers grater than 1000
                if(valueNum > 1000)
                {
                    continue;
                }

                sum += valueNum;
            }

            //handle negative numbers if any
            if(negFlag)
            {
                string str = ""; 
                foreach(int value in negs)
                {
                    str += value.ToString() + ", ";
                }
                str = str.Substring(0, str.Length - 2);


                throw new Exception(string.Format("negative numbers not allowed: {0}", str));
            }

            return sum;
        }
    }
}