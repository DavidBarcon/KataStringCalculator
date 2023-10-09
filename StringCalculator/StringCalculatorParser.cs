using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorParser
    {
        public StringCalculatorParser() { }

        public string[] parseString(string numbers)
        {
            char separator = ',';
            //copy the string to modify it
            string numbersCopy = (string)numbers.Clone();

            //get the separator if specified
            if (numbersCopy.Contains("//"))
            {
                separator = numbersCopy[2];
                numbersCopy = numbersCopy.Substring(3);
            }

            //replace \n by the separator
            numbersCopy = numbersCopy.Replace("\n", separator.ToString());

            //divide the sring and sum its elements
            string[] finalValues = numbersCopy.Split(separator);

            return finalValues;
        }

        public void hasNegatives(string[] values)
        {
            var negativeNumbers = new List<int>();

            //get all negative numbers
            foreach (string value in values)
            {
                int valueInt = Int32.Parse(value);

                //if there are negative numbers, add them to a list and handle them later
                if (valueInt < 0)
                {
                    negativeNumbers.Add(valueInt);
                }
            }

            //handle negative numbers if any
            if (negativeNumbers.Count > 0)
            {
                string expetionString = "";
                foreach (int value in negativeNumbers)
                {
                    expetionString += value.ToString() + ", ";
                }
                expetionString = expetionString.Substring(0, expetionString.Length - 2);


                throw new Exception(string.Format("negative numbers not allowed: {0}", expetionString));
            }


        }
    }
}
