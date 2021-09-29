class Solution(object):
    def isBST(self, root, minNode, maxNode):
        if not root:
            return True 
        # if minNode and root.val <= minNode.val:
        #     return False 
        # if maxNode and root.val >= maxNode.val:
        #     return False
        # return self.isBST(root.left, minNode, root) and self.isBST(root.right, root, maxNode) 
        if minNode and root.val <= minNode:
            return False 
        if maxNode and root.val >= maxNode:
            return False 
        return self.isBST(root.left, minNode, root.val) and self.isBST(root.right, root.val, maxNode)
            
    def curSum(self, root):
        if not root:
            return 0
        res = 0 
        if root.left:
            res += self.curSum(root.left)
        if root.right:
            res += self.curSum(root.right)
        res += root.val 
        self.res = max(self.res, res)
        return res 
    
    def traverser(self, root):
        if self.isBST(root, -float('inf'), float('inf')) == True: 
            _ = self.curSum(root)
            return 
        self.traverser(root.left)
        self.traverser(root.right)

    def maxSumBST(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        self.res = 0
        self.traverser(root)
        return self.res 
