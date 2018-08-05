using NUnit.Framework;
using System;

namespace Test.Services
{
    [TestFixture]
    public class Tests
    {        
        [Test]
        public void TestFibonacci()
        {
            TestService _testService = new TestService();
            var result1 = _testService.GetFibonacci(0);
            var result2 = _testService.GetFibonacci(1);
            var result3 = _testService.GetFibonacci(2);
            var result4 = _testService.GetFibonacci(3);

            Assert.AreEqual(0, result1);
            Assert.AreEqual(1, result2);
            Assert.AreEqual(1, result3);
            Assert.AreEqual(2, result4);
        }

        [Test]
        public void TestFizzBuzz()
        {
            TestService _testService = new TestService();

            var result1 = _testService.FizzBuzz(3);
            Assert.AreEqual("Fizz", result1);

            var result2 = _testService.FizzBuzz(5);
            Assert.AreEqual("Buzz", result2);

            var result3 = _testService.FizzBuzz(6);
            Assert.AreEqual("Fizz", result3);

            var result4 = _testService.FizzBuzz(7);
            Assert.AreEqual("", result4);

            var result5 = _testService.FizzBuzz(10);
            Assert.AreEqual("Buzz", result5);

            var result6 = _testService.FizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result6);

            var result7 = _testService.FizzBuzz(30);
            Assert.AreEqual("FizzBuzz", result7);
        }

        [Test]
        public void IfEmptyString_ReturnZero()
        {
            TestService _testService = new TestService();
            var str = String.Empty;
            var result = _testService.StringCalculator(str);
            var expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfSingleNumber_ReturnValue()
        {
            TestService _testService = new TestService();
            var str = "9";
            var result = _testService.StringCalculator(str);
            var expectedResult = 9;
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfTwoNumbersCommaDelimited_ReturnSum()
        {
            TestService _testService = new TestService();
            var str = "9, 10";
            var result = _testService.StringCalculator(str);
            var expectedResult = 19;
            Assert.AreEqual(expectedResult, result);   
        }

        [Test]
        public void IfTwoNumbersNewLineDelimited_ReturnSum()
        {
            TestService _testService = new TestService();
            var str = "7 \r\n 10";
            var result = _testService.StringCalculator(str);
            var expectedResult = 17;
            Assert.AreEqual(expectedResult, result);   
        }

        [Test]
        public void IfThreeNumbersDelimitedAnyWay_ReturnSum()
        {
            TestService _testService = new TestService();
            var str1 = "4 \r\n 10, 10";
            var result = _testService.StringCalculator(str1);
            var expectedResult = 24;
            Assert.AreEqual(expectedResult, result);  
        }

        [Test]
        public void NegativeNumberThrowsAnExceptions()
        {
            TestService _testService = new TestService();
            var str1 = "-5";
            var ex = Assert.Throws<System.ArgumentException>(() => _testService.StringCalculator(str1));

            Assert.IsTrue(ex.Message.Contains("Negative number"));
        }

        [Test]
        public void NumberGreaterThan1000_Ignore()
        {
            TestService _testService = new TestService();
            var str1 = "1000, 7, 999";
            var result = _testService.StringCalculator(str1);
            Assert.AreEqual(1006, result); 
        }


    }
}