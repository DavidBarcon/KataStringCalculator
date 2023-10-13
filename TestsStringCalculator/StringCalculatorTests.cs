using StringCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsStringCalculator
{
    

    [TestClass]
    public class StringCalculator_should
    {
        StringCalculator.StringCalculator stringCalculator;
        public StringCalculator_should() {
            StringCalculatorParser parser = new StringCalculatorParser();
            stringCalculator = new StringCalculator.StringCalculator(parser);
        }

        [TestMethod]
        public void return_1_when_passed_1()
        {
            String values= "1";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 1);

        }

        [TestMethod]
        public void return_3_when_passed_1_and_2()
        {
            String values = "1,2";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 3);

        }

        [TestMethod]
        public void return_sum_when_passed_many_values()
        {
            String values = "1,1,1,1,1,1,1,1,1,1";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 10);

        }

        [TestMethod]
        public void consider_new_lines_as_separators()
        {
            String values = "1\n2,4,2\n1";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 10);

        }

        [TestMethod]
        public void use_other_delimiters_when_stated()
        {
            String values = "//;1;2;5;1\n6";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 15);

        }

        [TestMethod]
        public void throw_when_negative_numbers()
        {
            String values = "1,2,-3,4,5,-6";


            int res = 0;
            string message = "";

            try
            {

                stringCalculator.add(values);

                Assert.Fail();
            }
            catch (Exception e)
            {

                message = e.Message;
            }

            Assert.AreEqual<string>(message, "negative numbers not allowed: -3, -6");
            
        }

        [TestMethod]
        public void ignore_big_numbers()
        {
            String values = "999,1,1001";

            int res = stringCalculator.add(values);
            Assert.AreEqual(res, 1000);

        }
    }
}