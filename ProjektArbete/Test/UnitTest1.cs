using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjektArbete;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Fifteen_And_Thirty_Output()
        //Test the output of progrem when the number is 15 and the then when it is 30
        {
            // Create an instance to test:  
            Runtime runtime = new Runtime();
            // Define a test output value:  
            string expectedResult = "CocaCola";
            // Run the method under test:  
            string actualResult1 = runtime.Check(15);
            string actualResult2 = runtime.Check(30);
            // Verify the result:  
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void Test_ThirtyThree_And_ThirtyNine_Output()
        //Test the output of progrem when the number is 33 and the then when it is 39
        {
            // Create an instance to test:  
            Runtime runtime = new Runtime();
            // Define a test output value:  
            string expectedResult = "Coca";
            // Run the method under test:  
            string actualResult1 = runtime.Check(33);
            string actualResult2 = runtime.Check(39);
            // Verify the result:  
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void Test_TwoHundred_And_Thousand_Output()
        //Test the output of progrem when the number is 200 and the then when it is 1000
        {
            // Create an instance to test:  
            Runtime runtime = new Runtime();
            // Define a test output value:  
            string expectedResult = "Cola";
            // Run the method under test:  
            string actualResult1 = runtime.Check(200);
            string actualResult2 = runtime.Check(1000);
            // Verify the result:  
            Assert.AreEqual(expectedResult, actualResult1);
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void Test_Seven_And_SevenHundredSeventyEight_Output()
        //Test the output of progrem when the number is 7 and the then when it is 778
        {
            // Create an instance to test:  
            Runtime runtime = new Runtime();
            // Define a test output value:  
            string expectedResult1 = "7";
            string expectedResult2 = "778";
            // Run the method under test:  
            string actualResult1 = runtime.Check(7);
            string actualResult2 = runtime.Check(778);
            // Verify the result:  
            Assert.AreEqual(expectedResult1, actualResult1);
            Assert.AreEqual(expectedResult2, actualResult2);
        }

    }
}
