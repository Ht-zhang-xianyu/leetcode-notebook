class Solution(object):
    def isBalanced(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        if not root:
            return True 
        left = self.maxDepth(root.left)
        right = self.maxDepth(root.right)
        if abs(right - left) > 1:
            return False 
        return self.isBalanced(root.left) and self.isBalanced(root.right) 

    def maxDepth(self, root):
        if not root:
            return 0
        return max(self.maxDepth(root.left), self.maxDepth(root.right))+1
