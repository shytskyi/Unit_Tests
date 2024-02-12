using BL;

namespace UnitTestProject
{
    public class LiczbaFibonacciTest
    {
        [Fact]
        public void LiczbaFibonacci_ExceptedCountRowne20()
        {
            // Arrange
            List<int> ints = new List<int> { 2, 3 };

            // Act
            List<int> fibonacciNumbers = LiczbaFibonacci.Fibonacci(ints);

            // Assert
            Assert.Equal(20, fibonacciNumbers.Count);

            // Verify Fibonacci sequence

        }

        [Fact]
        public void LiczbaFibonacci_VerifyFibonacci()
        {
            // Arrange
            List<int> ints = new List<int> { 2, 3 };

            // Act
            List<int> fibonacciNumbers = LiczbaFibonacci.Fibonacci(ints);

            //Assert
            for (int i = 2; i < fibonacciNumbers.Count; i++)
            {
                Assert.Equal(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2], fibonacciNumbers[i]);
            }
        }

        [Fact]
        public void LiczbaFibonacci_ArgumentOutOfRangeException()
        {
            // Arrange
            List<int> ints = new List<int>();

            //Act & Assert
            while (LiczbaFibonacci.Fibonacci(ints).Count < 20)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => LiczbaFibonacci.Fibonacci(ints));
            }
        }

        [Fact]
        public void LiczbaFibonacci_ArgumentNullException()
        {
            // Arrange
            List<int> ints = null;

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => LiczbaFibonacci.Fibonacci(ints));
        }
    }
}
