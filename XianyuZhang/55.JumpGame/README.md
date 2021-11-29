### [55. 跳跃游戏](https://leetcode-cn.com/problems/jump-game/)

#### Description

给定数组，和每一步其可以跳跃的步数，判断其是否可以跳到最后一个台阶

```python
输入：nums = [2,3,1,1,4]
输出：true
解释：可以先跳 1 步，从下标 0 到达下标 1, 然后再从下标 1 跳 3 步到达最后一个下标。
```



#### Solution

每一步都看当前最远可以跳到哪里，如果其小于或者等于当前的位置(`<=i`)就直接返回说到不了最后的位置，否则看其最远步伐是否等于数组的长度



#### Code

```python
class Solution(object):
    def canJump(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        temp = 0
        for i, num in enumerate(nums[:-1]):
            temp = max(temp, i+nums[i])
            if temp <= i:
                return False 
        return temp >= len(nums)-1
```

