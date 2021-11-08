### [90. 子集 II](https://leetcode-cn.com/problems/subsets-ii/)

#### Description

给你一个整数数组`nums` ，其中可能包含重复元素，请你返回该数组所有可能的子集（幂集）。

解集 不能 包含重复的子集。返回的解集中，子集可以按 任意顺序 排列

```python
输入：nums = [1,2,2]
输出：[[],[1],[1,2],[1,2,2],[2],[2,2]]
```



#### Solution

该题目与子集题目类似，但是涉及到了重复元素的问题，当遇到重复元素时，避免添加两次到结果答案（即出现两次`1,2,2`的结果）

剪枝的相关写法如下

```python
for i in range(start, len(nums)):
  if i > start and nums[i] == nums[i-1]:
    continue 
  xxx.append(nums[i])
  backTracking(nums, i+1)
  xxx.pop()
```

`i`代表当前我们处理的元素，当它大于`start`且跟上个元素相等时，即是出现重复，需要将其删除



#### Code

```python
class Solution(object):
    def subsetsWithDup(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        res, tmp_res = list(), list()
        nums = sorted(nums)
        def backTracking(nums, start):
            res.append(tmp_res[:])
            for i in range(start, len(nums)):
                if i > start and nums[i] == nums[i-1]:
                    continue 
                tmp_res.append(nums[i])
                backTracking(nums, i+1)
                tmp_res.pop()
        backTracking(nums, 0)
        return res 
```

