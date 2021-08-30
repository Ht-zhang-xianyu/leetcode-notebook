class Solution(object):
    def goodNodes(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        res = []
        def helper(root, val):
            if not root:
                return 
            if root.val >= val:
                val = root.val 
                res.append(val)
            helper(root.left, val)
            helper(root.right, val)
        helper(root, root.val)
        return len(res)
