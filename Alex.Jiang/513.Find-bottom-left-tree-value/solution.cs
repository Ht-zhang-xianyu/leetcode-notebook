public class Solution
{
    public int FindBottomLeftValue(TreeNode root)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int result = root.val;
        while (q.Count != 0)
        {
            int length = q.Count;
            result = q.Peek().val;
            for (int i = 0; i < length; i++)
            {
                TreeNode node = q.Dequeue();
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
        }
        return result;
    }
}