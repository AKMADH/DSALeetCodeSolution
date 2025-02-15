public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        return SumXor(nums, 0, 0);
    }

    public int SumXor(int[] nums, int i, int current)
    {
        if (nums.Length == i)
        {
            return current;
        }
        return SumXor(nums, i + 1, current ^ nums[i]) + SumXor(nums, i + 1, current);
    }
}