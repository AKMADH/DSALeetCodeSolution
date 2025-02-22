using System;
using System.Collections.Generic;
namespace Application
{
	public class CountPrimeSetBits
	{
        public int CountPrimeSetBits(int left, int right)
        {
            int primecount = 0;
            for (int i = left; i <= right; i++)
            {
                if (Isprime(CountSetBits(i)))
                {
                    primecount++;
                }
            }
            return primecount;
        }

        public bool IsPrime(int n)
        {
            if (n <2)
            {
                return false;
            }
            for (int i = 2; i <=Math.Sqrt(n); i++)
            {

                if (n % i == 0 )
                {
                    return false;
                }
            }
            return true; 
        }

        public int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += (n & 1);  // Increment count if the least significant bit is 1
                n >>= 1;  // Right shift the number to check the next bit
            }
            return count;
        }
    }
}

