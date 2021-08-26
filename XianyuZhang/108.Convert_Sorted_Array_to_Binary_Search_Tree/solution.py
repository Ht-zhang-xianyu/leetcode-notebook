class Solution(object):
    def sortedArrayToBST(self, nums):
        """
        :type nums: List[int]
        :rtype: TreeNode
        """
        root = self.build(nums, 0, len(nums)-1)
        return root 
    
    def build(self, nums, low, high):
        if low > high:
            return None 
        mid = low + (high - low) / 2
        root = TreeNode(nums[mid])
        root.left = self.build(nums, low, mid-1)
        root.right = self.build(nums, mid+1, high)
        return root 
