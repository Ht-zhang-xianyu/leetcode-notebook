### [1026. 节点与其祖先之间的最大差值](https://leetcode-cn.com/problems/maximum-difference-between-node-and-ancestor/)

#### Description

找出不同节点的最大差值



#### Solution

先有一个全局变量用于存储最大的差值结果，再有一个函数用于传递到当前节点的最大值最小值，然后前序遍历，当每到一个节点，计算差值，更新最大最小值，当树遍历完，就可以得到最大的差值了



#### Code

```python
class Solution(object):
    def maxAncestorDiff(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        #全局变量，用于每次更新
        self.res = 0
        # 辅助函数，每次用于当前节点的最大最小值
        def helper(root, min_value, max_value):
            if not root:
                return
            #更新结果
            self.res = max(abs(root.val - min_value), abs(root.val-max_value),\
                           self.res)
            min_value = min(root.val, min_value)
            max_value = max(root.val, max_value)
            helper(root.left, min_value, max_value)
            helper(root.right, min_value, max_value) 
        helper(root, root.val, root.val)
        return self.res 
```

