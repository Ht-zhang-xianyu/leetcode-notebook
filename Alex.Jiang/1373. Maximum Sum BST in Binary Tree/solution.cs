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
    int max;
    public int MaxSumBST(TreeNode root) {
        max = 0;
        dfs(root);
        return max;
    }
    
    //min,max,sum,isBST
    public (int,int,int,bool) dfs(TreeNode root){
        if(root == null)
            return (int.MaxValue,int.MinValue,0,true);
        var (lmin,lmax,lsum,lv) = dfs(root.left);
        var (rmin,rmax,rsum,rv) = dfs(root.right);
        bool isBST = lv && rv && lmax < root.val && rmin > root.val;
        int sum = isBST ? lsum + rsum + root.val:-1;
        max = Math.Max(sum, max);
        return (Math.Min(lmin, root.val), Math.Max(rmax,root.val),sum,isBST);
    }
}