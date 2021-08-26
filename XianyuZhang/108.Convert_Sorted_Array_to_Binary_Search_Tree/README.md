## [108. 将有序数组转换为二叉搜索树](https://leetcode-cn.com/problems/convert-sorted-array-to-binary-search-tree/)

#### Description

给定一个数组，将其建成一个左右高度平衡的二叉搜索树



#### Solution

左右平衡的二叉搜索树，可以尝试说取中点为根节点，然后将左边部分作为其左子树，右边部分作为其右子树，然后递归进行，此时可能需要设计一个新的函数，用以控制数组的边界。

构建二叉树的题目，都需要有返回值，将其返回值分别作为其左右子树的结构就可以了。



#### Code

```python
class Solution(object):
    def sortedArrayToBST(self, nums):
        """
        :type nums: List[int]
        :rtype: TreeNode
        """
        # 根据辅助函数返回的树结构，作为最终的返回值
        root = self.build(nums, 0, len(nums)-1)
        return root 
    
    
    def build(self, nums, low, high):
        # 当左边界大于右边界时，作为返回的case	
        if low > high:
            return None 
        # 取中点作为根节点
        mid = low + (high - low) / 2
        root = TreeNode(nums[mid])
        # 递归的生成其左右子树
        root.left = self.build(nums, low, mid-1)
        root.right = self.build(nums, mid+1, high)
        return root 
```

