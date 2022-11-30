using System;

namespace Udemy
{
    public class SumOfDigits : Program 
    {
        //Method to find sum of digits
        public int sumOfDigits(int n)
        {
            if (n==0 || n<0)
            {
                return 0;
            }
            return (n%10) + sumOfDigits(n/10);
        }
    }
}