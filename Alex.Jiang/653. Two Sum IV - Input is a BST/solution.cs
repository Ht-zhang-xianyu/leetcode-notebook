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
    public bool FindTarget(TreeNode root, int k) {
        HashSet<int> set = new HashSet<int>();
        return helper(root,k,set);
    }
    
    public bool helper(TreeNode root, int k, HashSet<int> set){
        if(root == null)
            return false;
        int target = k - root.val;
        if(set.Contains(target))
            return true;
        set.Add(root.val);
        return helper(root.left,k,set) || helper(root.right,k,set);
    }
}