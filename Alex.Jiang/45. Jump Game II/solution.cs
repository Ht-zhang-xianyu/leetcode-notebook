public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length <= 1)
            return 0;
        int p = 0;
        int result = 0;
        while (p < nums.Length - 1)
        {
            p = findPosition(nums, p);
            result++;
        }
        return result;
    }

    private int findPosition(int[] nums, int p)
    {
        int loop = nums[p];
        int len = nums.Length;
        if (loop >= len - 1 - p)
            return len;
        int max = -1;
        int result = p;
        for (int i = 1; i <= loop; i++)
        {
            if (max <= nums[i + p] + i)
            {
                max = nums[i + p] + i;
                result = i + p;
            }
        }
        return max  > loop ? result : loop + p;
    }
}