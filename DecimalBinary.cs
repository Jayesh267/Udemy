using System;

namespace Udemy
{
    public class DecimalBinary : Program
    {
        public int decimalBinary(int n)
        {
            if (n==0)
                return 0;
            if (n<0)
                return -1;
            return (n % 2) + (10 * decimalBinary(n/2));
        }
    }
}