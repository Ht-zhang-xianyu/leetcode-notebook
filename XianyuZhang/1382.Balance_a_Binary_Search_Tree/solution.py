class Solution(object):
    def balanceBST(self, root):
        """
        :type root: TreeNode
        :rtype: TreeNode
        """
        res = []
        def inOrder(root):
            if not root:
                return 
            inOrder(root.left)
            res.append(root.val)
            inOrder(root.right)
        inOrder(root)
        root = self.helper(res, 0, len(res)-1)
        return root 

    def helper(self, res, left, right):
        if left > right:
            return 
        mid = left + (right - left) /2 
        root = TreeNode(res[mid])
        root.left = self.helper(res, left, mid-1)
        root.right = self.helper(res, mid+1, right)
        return root 
