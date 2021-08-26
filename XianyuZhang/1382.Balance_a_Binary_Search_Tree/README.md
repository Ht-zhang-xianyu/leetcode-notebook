## [1382. 将二叉搜索树变平衡](https://leetcode-cn.com/problems/balance-a-binary-search-tree/)

#### Description

给定二叉搜索树，返回平衡后的树



#### Solution

其实可以中序遍历，遍历后得到二叉树的有序数组，随后就可以是108题的思路了，将有序数组转换为二叉搜索树



#### Code

```python
class Solution(object):
    def balanceBST(self, root):
        """
        :type root: TreeNode
        :rtype: TreeNode
        """
        res = []
        #  用res存放中序遍历的结果
        def inOrder(root):
            if not root:
                return 
            inOrder(root.left)
            res.append(root.val)
            inOrder(root.right)
        inOrder(root)
        # 根据终须遍历的结果，构造一颗高度平衡的二叉搜索树
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
```

