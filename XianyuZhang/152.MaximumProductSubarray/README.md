### [152. 乘积最大子数组](https://leetcode-cn.com/problems/maximum-product-subarray/)

#### Description

(= =) 这是一道常写常忘的题了

给定整数数组`nums`,找出乘积最大的连续子数组，并返回该子数组的所对应的乘积

```python
输入: [2,3,-2,4]
输出: 6
解释: 子数组 [2,3] 有最大乘积 6。
  
输入: [-2,0,-1]
输出: 0
解释: 结果不能为 2, 因为 [-2,-1] 不是子数组。
```



#### Solution

由于有正数，有负数，可能存在说某个位置，按照以往的`dp[i] = max(dp[i-1]*num, num)`数组，可能存在说其到某个位置，负得很大，或者某个位置，正得很大，到下个位置都会有影响

但思路应该是没错的，这里我们需要保存3个`dp`数组，

`max_res`数组：用来保存到这里正数最大的乘积数组

`min_res`数组：一个用来保存到这里乘积最小的数组

`dp`数组：一个用来保存题目所要的最大乘积

每次更新的时候，需要三个数组的元素同时更新，这样就能保证，更新新的`dp`数组时，能够用最小的数（最负的负数），和最大的数（最大的正数）去乘以当前的数字，然后再在和`num`的数字取最大，就是题目所求了



#### Code

```python
class Solution(object):
    def maxProduct(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        if not nums:
            return 0
        dp = [-float('inf') for _ in range(len(nums))]
        cur_max = [num for num in nums]
        cur_min = [num for num in nums]
        for i, num in enumerate(nums):
            if i == 0:
                dp[i] = num 
            else:
                dp[i] = max(cur_min[i-1]*num, cur_max[i-1]*num, num)
                cur_max[i] = max(cur_max[i-1]*num, cur_min[i-1]*num, num)
                cur_min[i] = min(cur_max[i-1]*num, cur_min[i-1]*num, num)
        return max(dp)
```

