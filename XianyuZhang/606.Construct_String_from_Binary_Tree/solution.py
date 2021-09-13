class Solution(object):
    def tree2str(self, root):
        """
        :type root: TreeNode
        :rtype: str
        """
        if not root:
            return ""
        def helper(root):
            if not root:
                return ""
            if not root.left and not root.right:
                res = str(root.val)
            elif not root.right:
                res = str(root.val) + "(" + helper(root.left) + ")"
            else:
                res = str(root.val) + "(" + helper(root.left) + ")(" + helper(root.right) + ")"
            return res 
        
        res = helper(root)
        return res 
