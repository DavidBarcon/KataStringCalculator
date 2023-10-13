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

        public int[] parseString(string numbers)
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

            //divide the string into an array
            string[] stringValues = numbersCopy.Split(separator);

            //convert elements to int
            int[] intValues = stringToIntArray(stringValues);

            //check if there are negative numbers
            hasNegatives(intValues);

            //remove values greater than 1000 (changes their value to 0)
            int[] finalValues = removeGraeterThan1000(intValues);
            

            return finalValues;
        }

        private int[] removeGraeterThan1000(int[] values) {
            int[] ints = new int[values.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                if (values[i] < 1000)
                {
                    ints[i] = values[i];
                }
                else
                {
                    ints[i] = 0;
                }
            }
            return ints;
        }

        private int[] stringToIntArray(string[] numbers)
        {
            int[] ints = new int[numbers.Length];   

            for(int i= 0 ;i < ints.Length; i++)
            {
                ints[i] = Int32.Parse(numbers[i]);
            }
            return ints;

        }

        private void hasNegatives(int[] values)
        {
            var negativeNumbers = new List<int>();

            //get all negative numbers
            foreach (int value in values)
            {

                //if there are negative numbers, add them to a list and handle them later
                if (value < 0)
                {
                    negativeNumbers.Add(value);
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
