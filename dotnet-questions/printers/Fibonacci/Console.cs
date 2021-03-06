using NUnit.Framework;

namespace printers.Fibonacci
{
    public class Console
    {
        private static int Counter;

        public static int GetCount()
        {
            return Counter;
        }

        public static void Print(int number)
        {
            Assert.That(number, Is.EqualTo(f(Counter)), "expected " + f(Counter) + " and got " + number);
            Counter++;
        }

        private static int f(int n)
        {
            var result = 0;
            if (n == 0) return result;
            if (n == 1) { return ++result; }
            return f(n - 1) + f(n - 2);
        }
    }
}