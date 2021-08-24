## [513. Find Bottom Left Tree Value](https://leetcode-cn.com/problems/find-bottom-left-tree-value/)

### solution:

​	要求的是最下层的最左边的节点

​	可以采用说层级遍历的方式（基于广度），保留每一层的值，然后将最后一层的0号元素返回即可



### code:

```python
class Solution(object):
    def findBottomLeftValue(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        # 用list模仿一个队列进行层级遍历
        queue = [root]
        res = list()
        # 对队列进行while循环
        while queue:
            # 用以保存每层的结果
            layer_res = list()
            # 循环现有的队列的长度，如果有左右子节点\
            # 添加到队列中
            for i in range(len(queue)):
                tmp = queue.pop(0)
                if tmp.left:
                    queue.append(tmp.left)
                if tmp.right:
                    queue.append(tmp.right)
                layer_res.append(tmp.val)
            res.append(layer_res)
        # 返回最后一层的最左边就的数值即可以
        return res[-1][0]
```

