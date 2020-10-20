using System;

namespace TestMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.maximumIntegerNumber(2, 2, 1));
            Console.WriteLine(Program.maximumFloatNumber(2.2, 3.3, 1.1));
            Console.WriteLine(Program.maximumStringNumber("APPLE", "PEACH", "BANANA"));
        }
        public static int maximumIntegerNumber(int first, int second, int third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                return first;

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                return second;

            else
                return third;
        }

        public static double maximumFloatNumber(double first, double second, double third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                return first;

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                return second;

            else
                return third;
        }

        public static string maximumStringNumber(string first, string second, string third)
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

