using Xunit;

namespace Codenation.Challenge
{
    public class MathTest
    {

        [Fact]
        public void Fibonacci_Test()
        {            
            var math = new Math();
            var result = math.Fibonacci();
            Assert.NotNull(result);     
        }

        [Fact]
        public void Fibonacci_Quantidade()
        {
            var math = new Math();
            var result = math.Fibonacci();
            Assert.True(result.Count == 14);
        }

        [Fact]
        public void Is_Fibonacci_Test()
        {
            var math = new Math();
            Assert.True(math.IsFibonacci(5));
        }

        [Fact]
        public void Is_NotFibonacci_Test()
        {
            var math = new Math();
            Assert.False(math.IsFibonacci(4));
        }

        [Fact]
        public void Is_NotFibonacci_Test_Negativo()
        {
            var math = new Math();
            Assert.False(math.IsFibonacci(-1));
        }

        [Fact]
        public void Is_Fibonacci_TestHi()
        {
            var math = new Math();
            Assert.True(math.IsFibonacci(233));
        }

        [Fact]
        public void Is_NotFibonacci_TestRange()
        {
            var math = new Math();
            Assert.False(math.IsFibonacci(377));
        }
    }
}
