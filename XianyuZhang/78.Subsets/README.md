### [78. 子集](https://leetcode-cn.com/problems/subsets/)

#### Description

给定数组，返回子集

```python
输入：nums = [1,2,3]
输出：[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
```



#### Solution

常见的回溯法题目，该题目只要保证每次回溯的时候，不要重复到先前已经走过的路径就可以，所以需要有个`start`去控制其下标

回溯的循环思路如下

```python
def backTracking(nums, start):
  res.append(...)
  for i in range(start, len(nums)):
    tmp_res.append(nums[i])
    backTracking(nums, i+1)
    tmp_res.pop()
```



#### Code

```python
class Solution(object):
    def subsets(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        res, tmp_res = list(), list()
        def backTracking(nums, start):
            res.append(tmp_res[:])
            for i in range(start, len(nums)):
                tmp_res.append(nums[i])
                backTracking(nums, i+1)
                tmp_res.pop()
        backTracking(nums, 0)
        return res 
```

