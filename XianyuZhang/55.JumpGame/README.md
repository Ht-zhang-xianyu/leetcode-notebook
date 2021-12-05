### [55. 跳跃游戏](https://leetcode-cn.com/problems/jump-game/)

#### Description

给定数组，和每一步其可以跳跃的步数，判断其是否可以跳到最后一个台阶

```python
输入：nums = [2,3,1,1,4]
输出：true
解释：可以先跳 1 步，从下标 0 到达下标 1, 然后再从下标 1 跳 3 步到达最后一个下标。
```



#### Solution

##### 贪心

每步都计算当前的步伐可以到的最远的位置，如果最远的位置，到不了当前的位置，则可判定到不了



##### 动归

保留一个`dp`数组，`dp[i]`指代当前位置可以达到的最远位置，如果其到不了就返回**False**（其实 感觉贪心法 就是压缩状态的动归法）



#### Code

**贪心**

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



**动归**

```python
class Solution(object):
    def canJump(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        dp = [0 for _ in range(len(nums))]
        for i, num in enumerate(nums):
            if i == 0:
                dp[i] = num 
                continue 
            if dp[i-1] < i:
                return False 
            dp[i] = max(dp[i-1], num + i)
        return dp[-1] >= len(nums)-1
```

