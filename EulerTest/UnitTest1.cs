using NUnit.Framework;
using ProjectEuler;
namespace EulerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void SumOfMultiples3and5(int max, int expectedSum)
        {
            var result = Exercises.SumOfMultiples(max);
            Assert.AreEqual(expectedSum, result);
        }

        
        [TestCase(4000000, 4613732)]
        public void EvenFibonacciForNumbersUpTo10(int limit, int expectedSum)
        {
            var result = Exercises.EvenFibonacci(limit);
            Assert.AreEqual(expectedSum, result);
        }

        [TestCase(10, 2640)]
        [TestCase(100, 25164150)]
        public void DifferenceBetweenSquareSumAndSumOfSquares(int max, long expectedSum)
        {
            var result = Exercises.SumSquareDiff(max);
            Assert.AreEqual(expectedSum, result);
        }
        
        [TestCase(906609)]
        public void LargestPalindromeOf2ThreeDigitNumbers(int expectedSum)
        {
            var result = Exercises.LargestPalindromeProduct();
            Assert.AreEqual(expectedSum, result);
        }
    }
}