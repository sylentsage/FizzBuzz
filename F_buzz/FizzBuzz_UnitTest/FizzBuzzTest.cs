using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_UnitTest
{
    [TestClass]
    public class FizzBuzzTest
    {

        // Initalize FizzBuzz Object
        FizzBuzzComponent.FizzBuzz obj = new FizzBuzzComponent.FizzBuzz(3, 5);

        [TestMethod]
        public void Return_Fizz_When_Number_Is_Divisible_By_Only_3()
        {
            Assert.AreEqual(obj.PrintFizzBuzz(3), "Fizz");
            Assert.AreEqual(obj.PrintFizzBuzz(6), "Fizz");
            Assert.AreEqual(obj.PrintFizzBuzz(9), "Fizz");
        }


        [TestMethod]
        public void Return_Buzz_When_Number_Is_Divisable_By_Only_5()
        {
            Assert.AreEqual(obj.PrintFizzBuzz(5), "Buzz");
            Assert.AreEqual(obj.PrintFizzBuzz(10), "Buzz");
            Assert.AreEqual(obj.PrintFizzBuzz(20), "Buzz");
        
        }

        [TestMethod]
        public void Return_FizzBuzz_When_Number_Is_Divisable_By_3_And_5()
        {
            Assert.AreEqual(obj.PrintFizzBuzz(60), "FizzBuzz");
            Assert.AreEqual(obj.PrintFizzBuzz(75), "FizzBuzz");
            Assert.AreEqual(obj.PrintFizzBuzz(90), "FizzBuzz");

        }

        [TestMethod]
        public void Return_Number_When_Number_Isnot_Divisable_By_3_And_5()
        {
            Assert.AreEqual(obj.PrintFizzBuzz(11), "11");
            Assert.AreEqual(obj.PrintFizzBuzz(13), "13");
            Assert.AreEqual(obj.PrintFizzBuzz(19), "19");

        }
    }
}
