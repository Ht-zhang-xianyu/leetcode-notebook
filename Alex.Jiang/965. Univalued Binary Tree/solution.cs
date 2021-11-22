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
    public bool IsUnivalTree(TreeNode root) {
        return DFS(root, root.val);
    }
    
    public bool DFS(TreeNode root, int target){
        if(root == null)
            return true;
        return root.val == target && DFS(root.left, target) && DFS(root.right, target);
    }
}