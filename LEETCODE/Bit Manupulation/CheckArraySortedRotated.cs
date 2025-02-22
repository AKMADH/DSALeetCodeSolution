using System;
namespace Application
{
	public class CheckArraySortedRotated
	{
        public bool Check(int[] nums)
        {
            int countDips = 0;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > nums[(i + 1) % n])
                {
                    countDips++;
                }
            }

            return countDips <= 1;
        }
    }
}

