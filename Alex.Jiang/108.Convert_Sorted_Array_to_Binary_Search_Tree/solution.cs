public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Build(nums, 0, nums.Length - 1);
    }
    public TreeNode Build(int[] nums, int from, int to)
    {
        if (to < from)
            return null;
        int mid = (from + to) / 2;
        TreeNode current = new TreeNode(nums[mid]);
        current.left = Build(nums, from, mid - 1);
        current.right = Build(nums, mid + 1, to);
        return current;
    }
}