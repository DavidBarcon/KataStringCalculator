using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        int[] values; 

        public StringCalculator(string numbers) {
            //when an object is creted it is automatically parsed
            StringCalculatorParser parser = new StringCalculatorParser(numbers);
            values = parser.parseString();
        }

        //other methods can be created for other types of operations
        //add: sums all elements in the list and returns the result
        public int add()
        {
            return values.Sum();
        }
    }
}
