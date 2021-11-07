### [216. 组合总和 III](https://leetcode-cn.com/problems/combination-sum-iii/)

#### Descripton

找出从`1-9`相加和为`n`的`k`个数，且不能有重复



#### Solution

回溯法的模版，先建立一个`nums`的数组，每次从列表中找一个添加到`tmp_res`，如果其数目等于要求的`k`以及总和等于提及的`n`，就将其添加到结果的`res`中



#### Code

```python
class Solution(object):
    def combinationSum3(self, k, n):
        """
        :type k: int
        :type n: int
        :rtype: List[List[int]]
        """
        nums = [num+1 for num in range(9)]
        res, tmp_res = list(), list()
        def backTracking(nums, start):
            if len(tmp_res) == k and sum(tmp_res) == n:
                res.append(tmp_res[:])
                return 
            for i in range(start, len(nums)):
                tmp_res.append(nums[i])
                backTracking(nums, i+1)
                tmp_res.pop()
        backTracking(nums, 0)
        return res 
```