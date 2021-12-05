### [376. 摆动序列](https://leetcode-cn.com/problems/wiggle-subsequence/)

#### Description

给定一个数组，求其摆动序列的最长子序列长度

```python
输入：nums = [1,7,4,9,2,5]
输出：6
解释：整个序列均为摆动序列，各元素之间的差值为 (6, -3, 5, -7, 3) 。
```



#### Solution

##### 贪心：

（其实这里没太盘清用贪心的思路）
局部最优：当某段数组，是呈现单调的，就将其删除掉，就形成了一高一低的摆动序列

全局最优：整个数据的没有单调全部是峰，就是全局最优



##### 动归：

（其实这个思路也不是太容易想到）

保留一个`up`和`down`数组，数组的遍历会出现以下三个情况：

1、当前的元素比上个元素大时，则处于上升的单调，此时`up[i] = max(up[i-1], down[i-1]+1)` 

2、当前元素比上个元素小，则处于下降的单调，此时`down[i] = max(down[i-1], up[i-1]+1)`

3、碰上相等元素，`up down`数组取上一位置的就可以了

#### Code

##### 贪心

```python
class Solution(object):
    def wiggleMaxLength(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        if len(nums)<=2:
            return len(set(nums))
        pre_diff, cur_diff = 0, 0
        res = 1 
        for i in range(len(nums)):
            if i == 0:
                continue 
            cur_diff = nums[i] - nums[i-1]
            if cur_diff > 0 and pre_diff<=0:
                res += 1 
                pre_diff = cur_diff
            elif cur_diff < 0 and pre_diff >= 0:
                res += 1 
                pre_diff = cur_diff
        return res 
```



**动态规划**

```python
class Solution(object):
    def wiggleMaxLength(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        if len(set(nums)) == 1:
            return 1 
        if len(nums) <= 2:
            return len(set(nums))
        up = [1 for _ in range(len(nums))]
        down = [1 for _ in range(len(nums))]
        for i in range(len(nums)):
            if i == 0:
                continue 
            if nums[i] > nums[i-1]:
                up[i] = max(up[i-1], down[i-1] +1 )
                down[i] = down[i-1]
            elif nums[i] < nums[i-1]:
                up[i] = up[i-1]
                down[i] = max(up[i-1]+1, down[i-1])
            else:
                up[i] = up[i-1]
                down[i] = down[i-1]
        return max(down[-1], up[-1])
```

