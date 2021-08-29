public class Solution {
    public bool IsBalanced(TreeNode root) {
        
        if(root == null)
            return true;
        int left = maxDep(root.left, 0);
        int right =maxDep(root.right, 0);
        if(Math.Abs(right - left) > 1)
            return false;
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    public int maxDep(TreeNode root, int height){
        if(root == null)
            return height;
        height++;
        return Math.Max(maxDep(root.left, height), maxDep(root.right, height));
    }
}