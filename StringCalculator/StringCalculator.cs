using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        StringCalculatorParser parser;

        public StringCalculator(StringCalculatorParser parser) {
            this.parser = parser;
        }

        //other methods can be created for other types of operations
        //add: sums all elements in the list and returns the result
        public int add(String numbers)
        {
            int[] values = parser.parseString(numbers);
            return values.Sum();
        }
    }
}
