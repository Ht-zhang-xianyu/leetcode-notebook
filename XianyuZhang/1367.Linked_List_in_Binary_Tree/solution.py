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
