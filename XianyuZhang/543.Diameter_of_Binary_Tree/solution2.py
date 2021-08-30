class Solution(object):
    def diameterOfBinaryTree(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        self.res = 0
        def max_depth(root):
            if not root:
                return 0
            left_max = max_depth(root.left)
            right_max = max_depth(root.right)
            self.res = max(left_max+ right_max, self.res)
            return 1 + max(left_max, right_max)
        max_depth(root)
        return self.res 
