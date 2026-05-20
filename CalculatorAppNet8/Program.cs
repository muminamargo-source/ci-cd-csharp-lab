using CalculatorAppNet8;

namespace CalculatorAppNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int result = calc.Add(2, 3);
            Console.WriteLine($"2 + 3 = {result}");
        }
    }
}