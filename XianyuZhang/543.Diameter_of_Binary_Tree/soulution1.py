class Solution(object):
    def diameterOfBinaryTree(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        res = self.max_depth(root.left) + self.max_depth(root.right)
        if root.left:
            res = max(res, self.diameterOfBinaryTree(root.left))
        if root.right:
            res = max(res, self.diameterOfBinaryTree(root.right))
        return res 

    
    def max_depth(self, root):
        if not root:
            return 0
        return max(self.max_depth(root.left), self.max_depth(root.right)) + 1  
