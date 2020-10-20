using System;

namespace TestMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.MaximumValue<double>(2.2, 3.3, 1.1));
            Console.WriteLine(Program.MaximumValue<string>("APPLE", "PEACH", "BANANA"));
            Console.WriteLine(Program.MaximumValue<int>(2, 2, 1));
        }

        public static T MaximumValue<T>(T first, T second, T third) where T : IComparable<T>
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                return first;

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                return second;
            else
                return third;
        }
    }
}

