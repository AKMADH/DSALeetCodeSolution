using System;
using System.Collections.Generic;

namespace Application
{
	public class IntersectTwoArray
	{
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in nums1)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq.Add(num, 1);
                }
            }

            foreach (int num in nums2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            return result.ToArray();
        }
    }
}

