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
    public int MaxLevelSum(TreeNode root) {
        if(root == null)
            return 0;
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int max = Int32.MinValue;
        int row = 1, res = 0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                var curr = queue.Dequeue();
                sum += curr.val;
                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);
            }
            
            if(sum > max)
            {
                res = row;
                max = sum;
            }
            
            row++;
        }
        
        return res;
    }

}