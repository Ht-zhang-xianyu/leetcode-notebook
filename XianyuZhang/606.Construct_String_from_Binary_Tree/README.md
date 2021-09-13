### [606. 根据二叉树创建字符串](https://leetcode-cn.com/problems/construct-string-from-binary-tree/)

#### Description

基于前序遍历，将前序的序列转化为字符串输出



#### Solution



#### Code

```python
class Solution(object):
    def tree2str(self, root):
        """
        :type root: TreeNode
        :rtype: str
        """
        if not root:
            return ""
        def helper(root):
            if not root:
                return ""
            if not root.left and not root.right:
                res = str(root.val)
            elif not root.right:
                res = str(root.val) + "(" + helper(root.left) + ")"
            else:
                res = str(root.val) + "(" + helper(root.left) + ")(" + helper(root.right) + ")"
            return res 
        
        res = helper(root)
        return res 
```

