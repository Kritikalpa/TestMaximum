using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaxValue<T> where T : IComparable
    {
        public T first, second, third;

        public MaxValue(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public T MaximumValue()
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
