using Xunit;
using CalculatorAppNet8;   // ← это новая строчка

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}