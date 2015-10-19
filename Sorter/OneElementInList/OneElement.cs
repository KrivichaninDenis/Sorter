using System;
using System.Globalization;

namespace Sorter.OneElementInList
{
    public class OneElement:IComparable
    {
        public double IntValue { get; private set; }

        public OneElement(double value)
        {
            IntValue = value;
        }

        public override string ToString()
        {
            return IntValue.ToString(CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {                       
            return IntValue.CompareTo(((OneElement) obj).IntValue);
        }
    }
}
