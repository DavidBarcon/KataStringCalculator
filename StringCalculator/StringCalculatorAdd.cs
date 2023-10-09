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
            StringCalculatorParser parser = new StringCalculatorParser();

            //parse the string into the array with the numbers
            string[] parsedValues = parser.parseString(numbers);

            //check if the array has negatives
            parser.hasNegatives(parsedValues);
            
            int finalSum = 0;
            foreach (string value in parsedValues)
            {
                int valueInt = Int32.Parse(value);

                //ignore numbers grater than 1000
                if (valueInt > 1000)
                {
                    continue;
                }

                finalSum += valueInt;
            }

            return finalSum;
        }
    }
}
