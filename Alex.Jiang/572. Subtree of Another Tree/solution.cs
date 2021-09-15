public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null || subRoot == null)
            return root == subRoot;
        return helper(root,subRoot) || IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }
    
    
    private bool helper(TreeNode root, TreeNode subRoot){
        if(root == null || subRoot == null)
            return root == subRoot;
        if(root.val != subRoot.val)
            return false;
        return helper(root.left,subRoot.left) && helper(root.right,subRoot.right);
    }
}