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
            StringCalculator.StringCalculatorClass stringC= new StringCalculatorClass();

            int res = stringC.add(values);
            Assert.AreEqual(values, 1, string.Format("Expected {0} but got {1}", 1, res));

        }

        [TestMethod]
        public void Test2Values()
        {
            String values = "1,2";
            StringCalculator.StringCalculatorClass stringC = new StringCalculatorClass();

            int res = stringC.add(values);
            Assert.AreEqual(values, 3, string.Format("Expected {0} but got {1}", 3, res));

        }

        [TestMethod]
        public void TestManyValues()
        {
            String values = "1,1,1,1,1,1,1,1,1,1";
            StringCalculator.StringCalculatorClass stringC = new StringCalculatorClass();

            int res = stringC.add(values);
            Assert.AreEqual(values, 10, string.Format("Expected {0} but got {1}", 10, res));

        }
    }
}