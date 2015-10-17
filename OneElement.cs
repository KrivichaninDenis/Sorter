using System;

namespace Sorter
{
    class OneElement:IComparable
    {
        public double IntValue { get; private set; }

        public OneElement(int value)
        {
            IntValue = value;
        }

        public override string ToString()
        {
            return IntValue.ToString();
        }

        public int CompareTo(object obj)
        {                       
            return IntValue.CompareTo((obj as OneElement).IntValue);
        }
    }
}
