## [110. 平衡二叉树](https://leetcode-cn.com/problems/balanced-binary-tree/)

#### Description

给定一颗二叉树，判断其是否为高度平衡的二叉树



#### Solution

可以设置一个函数，用以计算二叉树左右子树的最大深度，当得到左右子树的最大深度时，用以计算其高度差， 如果大于1，就可以认为不是高度平衡的了



##### Code

```python
class Solution(object):
    def isBalanced(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        # 当计算到底的时候就认为是真
        if not root:
            return True 
        # 分别计算左右子树的高度，用以后续做差
        left = self.maxDepth(root.left)
        right = self.maxDepth(root.right)
        if abs(right - left) > 1:
            return False 
        return self.isBalanced(root.left) and self.isBalanced(root.right) 

    # 辅助函数，用以计算二叉树的高度
    def maxDepth(self, root):
        if not root:
            return 0
        return max(self.maxDepth(root.left), self.maxDepth(root.right))+1
```

