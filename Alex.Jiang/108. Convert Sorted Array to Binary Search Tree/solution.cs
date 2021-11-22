/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return DFS(nums,0,nums.Length-1);
    }
    
    public TreeNode DFS(int[] nums,int left, int right){
        if(left > right) return null;
        int index = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[index]);
        node.right = DFS(nums, index+1, right);
        node.left = DFS(nums,left, index-1);
        return node;
    }
}