### [543. 二叉树的直径](https://leetcode-cn.com/problems/diameter-of-binary-tree/)

#### Description

计算通过某些节点的最大路径和



#### Solution

可以转化为计算不同节点的最大左右深度之和，然后就可以求出答案 了



#### Code1

```python
class Solution(object):
    def diameterOfBinaryTree(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        res = self.max_depth(root.left) + self.max_depth(root.right)
        if root.left:
            res = max(res, self.diameterOfBinaryTree(root.left))
        if root.right:
            res = max(res, self.diameterOfBinaryTree(root.right))
        return res 

    
    def max_depth(self, root):
        if not root:
            return 0
        return max(self.max_depth(root.left), self.max_depth(root.right)) + 1 
```



#### Solution

但是其实有很多冗余的计算，例如计算深度的时候，每个节点都会被递归计算到，此时上面的写法 有点前序遍历的意思，先处理节点，再左右递归，可以考虑后序遍历的处理方式，先左右递归，再处理节点，这样某种程度会减少运算量，则有了如下的代码



#### Code

```python
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
```

