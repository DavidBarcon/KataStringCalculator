using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorAdder
    {
        public StringCalculatorAdder() { }


        public int add(String numbers)
        {
            //instance the parser class
            Parser parser = new Parser();

            //parse the string into the array with the numbers
            string[] values = parser.parseString(numbers);

            //check if the array has negatives
            parser.hasNegatives(values);
            
            int sum = 0;
            foreach (string value in values)
            {
                int valueNum = Int32.Parse(value);

                //ignore numbers grater than 1000
                if (valueNum > 1000)
                {
                    continue;
                }

                sum += valueNum;
            }

            return sum;
        }
    }
}
