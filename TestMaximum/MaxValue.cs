using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaxValue<T> where T : IComparable
    {
        public T[] values;

        public MaxValue(T[] inputArray)
        {
            this.values = inputArray;
        }

        public T MaximumValue()
        {
            Array.Sort(this.values);
            return this.values[^1];
        }
    }
}
