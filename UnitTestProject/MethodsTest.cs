using BL;

namespace UnitTestProject
{
    public class MethodsTest
    {
        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(1, 4, 3, 4)]
        [InlineData(5, 2, 3, 5)]
        public void MaxNumber_ReturnMax(int num1, int num2, int num3, int expected)
        {
            var max = new Methods();

            var result = max.MaxNumber(num1, num2, num3);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ParzystaLiczba_ReturnsTrue() 
        {
            var p = new Methods();
            var rsult = p.ParzystaLiczba(2);
            Assert.True(rsult);
        }

        [Fact]
        public void ParzystaLiczba_ReturnsFalse()
        {
            var p = new Methods();
            var rsult = p.ParzystaLiczba(3);
            Assert.False(rsult);
        }

        [Fact]
        public void Sum_ReturnsSum()
        {
            var s = new Methods();
            var result = s.Sum(1,2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Sum_ReturnsExeption()
        {
            var s = new Methods();
            var result = Assert.Throws<Exception>(() => s.Sum(-1, -2));
            Assert.Equal("nie spełnia warunku", result.Message);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(-1, 1)]
        public void GetAbsoluteNumber_ReturnsPozytywne(int x, int expected)
        {
            var a = new Methods();
            var result = a.GetAbsoluteNumber(x);
            Assert.Equal(expected, result);
        }
    }
}
