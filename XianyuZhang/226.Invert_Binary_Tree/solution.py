class Solution(object):
    def invertTree(self, root):
        """
        :type root: TreeNode
        :rtype: TreeNode
        """
        # 当没有节点时，返回
        if not root:
            return 
        # 进行变换操作
        root.left, root.right = root.right, root.left 
        # 递归对左右子树进行遍历
        self.invertTree(root.left)
        self.invertTree(root.right)
        return root 
