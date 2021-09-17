### [1373. 二叉搜索子树的最大键值和](https://leetcode-cn.com/problems/maximum-sum-bst-in-binary-tree/)

#### Description

一颗二叉树，树中有二叉搜索树，找到二叉树中，符合为二叉搜索树，且val总和最大的值



#### Solution

（刚开始自己写过了各种样例，以为可以自己AC一道困难题，结果超时，淦 = =）

大体上可以分解为，遍历，判断是否为二叉搜索树，如果是二叉搜索树就求其所有的值，多棵二叉所搜树求最大的值（但遍历的顺序，可能要斟酌，不然就超时了）



核心逻辑如下：

```python
def traverse(self, root)：
	# 判断是否为二叉搜索树
	if self.isBST(root):
    # 求二叉搜索树的最大饭回值
  	self.res = max(self.res, self.curSum(root))
    return 
  self.traverse(root.left)
  self.traverse(root.right)
```



这里比较重要的是需要前序遍历，当遍历到一个节点为二叉搜索树时，就计算其节点的值，然后就不往下走了。

一开始按照后序遍历的顺序写，会对整个树的每个节点都对是否为二叉搜索树进行判断，会超时。

（以及提醒自己判断是否为二叉搜索树的写法要牢记，这道题的核心）



#### Code

```python
class Solution(object):
    def isBST(self, root, minNode, maxNode):
        if not root:
            return True 
        if minNode and root.val <= minNode.val:
            return False 
        if maxNode and root.val >= maxNode.val:
            return False
        return self.isBST(root.left, minNode, root) and self.isBST(root.right, root, maxNode) 
        # if minNode and root.val <= minNode:
        #     return False 
        # if maxNode and root.val >= maxNode:
        #     return False 
        # return self.isBST(root.left, minNode, root.val) and self.isBST(root.right, root.val, maxNode)
            
    def curSum(self, root):
        if not root:
            return 0
        res = 0 
        if root.left:
            res += self.curSum(root.left)
        if root.right:
            res += self.curSum(root.right)
        res += root.val 
        self.res = max(self.res, res)
        return res 
    
    def traverser(self, root):
        if self.isBST(root, None, None) == True: 
            _ = self.curSum(root)
            return 
        self.traverser(root.left)
        self.traverser(root.right)


    def maxSumBST(self, root):
        """
        :type root: TreeNode
        :rtype: int
        """
        self.res = 0
        self.traverser(root)
        return self.res 
```

