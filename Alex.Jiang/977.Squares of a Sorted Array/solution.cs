public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int flag = 0;
        var result = new List<int>();
        for (flag = 0; flag < nums.Length; flag++)
        {
            if (nums[flag] > 0) break;
        }

        int left = flag - 1;
        while (left >= 0 && flag < nums.Length)
        {
            int leftv = nums[left] * nums[left];
            int rightv = nums[flag] * nums[flag];
            if (leftv < rightv)
            {
                result.Add(leftv);
                left--;
            }
            else
            {
                result.Add(rightv);
                flag++;
            }
        }

        while (left >= 0)
        {
            result.Add(nums[left] * nums[left--]);
        }

        while (flag < nums.Length)
        {
            result.Add(nums[flag] * nums[flag++]);
        }

        return result.ToArray();
    }
    public int[] SortedSquares(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int n = nums.Length - 1;
        int[] result = new int[n + 1];
        for (; n >= 0; n--)
        {
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[n] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[n] = nums[right] * nums[right];
                right--;
            }
        }
        return result;
    }
}