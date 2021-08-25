public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0;
        int leftsum = 0;
        foreach (var n in nums)
        {
            sum += n;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftsum == sum - leftsum - nums[i])
                return i;
            leftsum += nums[i];
        }
        return -1;
    }
}