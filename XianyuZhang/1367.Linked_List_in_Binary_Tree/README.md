### [1367. 二叉树中的列表](https://leetcode-cn.com/problems/linked-list-in-binary-tree/)

#### Description

判断链表中的节点在二叉树中是否存在



#### Solution

当遍历到二叉树的节点时，开始判断，当节点时不同于链表的节点时，返回False,当链表的节点遍历到最后一个，返回true，否则当有节点不同就返回false，对于递归中的遍历以及左右子树的遍历，可以参考这道题目中

```python
self.helper(root) or self.main(root.left) or self.main(root.right)
```



Code

```python
class Solution(object):
    def isSubPath(self, head, root):
        """
        :type head: ListNode
        :type root: TreeNode
        :rtype: bool
        """
        if not root:
            return False 
        return self.helper(head, root) or self.isSubPath(head, root.left) or self.isSubPath(head, root.right)
        
    def helper(self, head, root):
        if not head:
            return True 
        if not root:
            return False 
        if head.val != root.val:
            return False 
        return self.helper(head.next, root.left) or self.helper(head.next, root.right)
```

