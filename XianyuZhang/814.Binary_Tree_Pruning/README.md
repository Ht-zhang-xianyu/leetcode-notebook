### [814. 二叉树剪枝](https://leetcode-cn.com/problems/binary-tree-pruning/)

#### Description

给定二叉树的根节点，此外树的每个节点的值要么是0，要么是1，移除所有不包含1的二叉树



#### Solution

见示例2，当叶子节点是0时，是需要网上再看，如果还是0，则需要继续删除，由此决定了说，这会需要的是后序遍历的题目，且由于是修改二叉树的题目，则需要饭回值，移除对应的行动，大体上是返回None，由此就可以写出代码了



#### Code

```python
class Solution(object):
    def pruneTree(self, root):
        """
        :type root: Optional[TreeNode]
        :rtype: Optional[TreeNode]
        """
        if not root:
            return 
        # 后序遍历的套路
        root.left =  self.pruneTree(root.left)
        root.right = self.pruneTree(root.right)
        if not root.right and not root.left and root.val == 0:
            # 符合条件时，该节点置空
            return None
        return root 
```

