using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Parser
    {
        public Parser() { }

        public string[] parseString(string numbers)
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

            return values;
        }

        public void hasNegatives(string[] values)
        {
            var negs = new List<int>();

            //get all negative numbers
            foreach (string value in values)
            {
                int valueNum = Int32.Parse(value);

                //if there are negative numbers, add them to a list and handle them later
                if (valueNum < 0)
                {
                    negs.Add(valueNum);
                }
            }

            //handle negative numbers if any
            if (negs.Count > 0)
            {
                string str = "";
                foreach (int value in negs)
                {
                    str += value.ToString() + ", ";
                }
                str = str.Substring(0, str.Length - 2);


                throw new Exception(string.Format("negative numbers not allowed: {0}", str));
            }


        }
    }
}
