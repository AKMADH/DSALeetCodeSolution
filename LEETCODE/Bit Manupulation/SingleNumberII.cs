using System;
namespace Application
{
	public class SingleNumberII
	{
        public int SingleNumber(int[] nums)
        {
            // 1) First Approach
            /* int res = 0;
             for (int i = 1; i < 32; i++)
             {
                 for (int j = 0; j < nums.Length; j++)
                 {
                     int sum = 0;
                     if ((nums[j]>>i) & 1 ==1)
                     {
                         sum++;
                     }
                     sum %= 3;
                     if (sum != 0)
                     {
                         res |= res << i;
                     }
                 }

             }
            return res;*/
            //2nd Approach
            int ones = 0;
            int twos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ones = (ones ^ nums[i]) & ~twos;
                twos = (twos ^ nums[i]) & ~ones;
            }
            return ones;
        }
    }
}

