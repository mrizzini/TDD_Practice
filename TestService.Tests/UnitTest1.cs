using NUnit.Framework;
using System;

namespace Test.Services
{
    public class Tests
    {        
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