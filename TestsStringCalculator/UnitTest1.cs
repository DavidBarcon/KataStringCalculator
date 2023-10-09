using StringCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsStringCalculator
{
    

    [TestClass]
    public class UnitTestStep1
    {
        [TestMethod]
        public void Test1Value()
        {
            String values= "1";
            StringCalculator.StringCalculatorAdder stringC= new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 1, string.Format("Expected {0} but got {1}", 1, res));

        }

        [TestMethod]
        public void Test2Values()
        {
            String values = "1,2";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 3, string.Format("Expected {0} but got {1}", 3, res));

        }

        [TestMethod]
        public void TestManyValues()
        {
            String values = "1,1,1,1,1,1,1,1,1,1";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 10, string.Format("Expected {0} but got {1}", 10, res));

        }

        [TestMethod]
        public void TestNewLines()
        {
            String values = "1\n2,4,2\n1";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 10, string.Format("Expected {0} but got {1}", 10, res));

        }

        [TestMethod]
        public void TestOtherDelimiter()
        {
            String values = "//;1;2;5;1\n6";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 15, string.Format("Expected {0} but got {1}", 15, res));

        }

        [TestMethod]
        public void TestNegatives()
        {
            String values = "1,2,-3,4,5,-6";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = 0;
            string message = "";

            try
            {
                res = stringC.add(values);
                Assert.Fail();
            }
            catch (Exception e)
            {

                message = e.Message;
            }

            Assert.AreEqual<string>(message, "negative numbers not allowed: -3, -6",
                String.Format("The wrong exeption was trown. Expected: {0}, but got: {1}", 
                "negative numbers not allowed: -3, -6", message));
            
        }

        [TestMethod]
        public void TestBigNumbers()
        {
            String values = "999,1,1001";
            StringCalculator.StringCalculatorAdder stringC = new StringCalculatorAdder();

            int res = stringC.add(values);
            Assert.AreEqual(res, 1000, string.Format("Expected {0} but got {1}", 1000, res));

        }
    }
}