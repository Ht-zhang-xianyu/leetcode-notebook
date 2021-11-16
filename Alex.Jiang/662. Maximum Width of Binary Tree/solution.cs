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
    public int WidthOfBinaryTree(TreeNode root) {
       int max_width = 0;
		Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
		queue.Enqueue((root, 0));

		while(queue.Count > 0)
		{
			int size = queue.Count, left = int.MaxValue, right = int.MinValue;

			for(int i = 0; i < size; i++)
			{
				(TreeNode, int) node = queue.Dequeue();
				left = Math.Min(left, node.Item2);
				right = Math.Max(right, node.Item2);

				if (node.Item1.left != null)
					queue.Enqueue((node.Item1.left, 2 * node.Item2 + 1));

				if (node.Item1.right != null)
					queue.Enqueue((node.Item1.right, 2 * node.Item2 + 2));
			}

			max_width = Math.Max(max_width, right - left + 1);
		}

		return max_width;
    }
}