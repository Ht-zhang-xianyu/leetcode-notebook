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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return DFS(root,targetSum,0);
    }
    
    public bool DFS(TreeNode node, int targetSum, int currentSum){
        if(node == null)
            return false;
        if(node.left == null && node.right == null && currentSum + node.val == targetSum)
            return true;
        return DFS(node.left, targetSum, currentSum+node.val) || DFS(node.right, targetSum, currentSum+node.val);
    }
}