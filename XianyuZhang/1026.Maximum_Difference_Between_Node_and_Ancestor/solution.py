class Solution(object):
    def maxAncestorDiff(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        self.res = 0
        def helper(root, min_value, max_value):
            if not root:
                return
            self.res = max(abs(root.val - min_value), abs(root.val-max_value),\
                           self.res)
            min_value = min(root.val, min_value)
            max_value = max(root.val, max_value)
            helper(root.left, min_value, max_value)
            helper(root.right, min_value, max_value) 
        helper(root, root.val, root.val)
        return self.res 
