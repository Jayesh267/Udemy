using System;

namespace Udemy
{
    public class Power : Program
    {
        //find power of a number
        public int npower(int n, int exp)
        {
            if (exp==1)
            {
                return n;
            }
            if (exp==0)
            {
                return 1;
            }
            if (exp<0)
            {
                return -1;
            }
            return n * npower(n, exp-1);
        }
    }
}