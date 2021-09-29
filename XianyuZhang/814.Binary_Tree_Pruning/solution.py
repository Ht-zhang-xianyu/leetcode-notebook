class Solution(object):
    def pruneTree(self, root):
        """
        :type root: Optional[TreeNode]
        :rtype: Optional[TreeNode]
        """
        if not root:
            return 
        root.left =  self.pruneTree(root.left)
        root.right = self.pruneTree(root.right)
        if not root.right and not root.left and root.val == 0:
            root = None
            return root 
        return root 
