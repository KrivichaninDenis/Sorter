using System;
using System.Globalization;

namespace MasSortLibrary.OneElementInList
{
    public class OneElement
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
    }
}
