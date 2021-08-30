### [1448. 统计二叉树中好节点的数目](https://leetcode-cn.com/problems/count-good-nodes-in-binary-tree/)

#### Description

统计从根节点到该节点没有超过该节点值的总数



#### Solution

大概可以维护一个列表，然后采用前序遍历的方法，当节点大于前面的节点，就加入到列表中，最终返回列表的长度就可以了



#### Code

```python
class Solution(object):
    def goodNodes(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        if not root:
            return 0
        res = []
        def helper(root, val):
            if not root:
                return 
            if root.val >= val:
                val = root.val 
                res.append(val)
            helper(root.left, val)
            helper(root.right, val)
        helper(root, root.val)
        return len(res)
```

