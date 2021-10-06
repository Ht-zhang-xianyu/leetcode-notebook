#### [226. Invert Binary Tree](https://leetcode-cn.com/problems/invert-binary-tree/)

### Description

即是将左右子树进行翻转



### Solution

核心应该是 对每个节点的左子树与右子树的调换，然后递归调用该函数去遍历其左子树和右子树就可以了



### Code 

```python
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
```

