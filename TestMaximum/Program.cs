using System;

namespace TestMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MaxValue<double>(2.2, 3.3, 1.1).MaximumValue());
            Console.WriteLine(new MaxValue<string>("APPLE", "PEACH", "BANANA").MaximumValue());
            Console.WriteLine(new MaxValue<int>(2, 2, 1).MaximumValue());
        }
    }
}

