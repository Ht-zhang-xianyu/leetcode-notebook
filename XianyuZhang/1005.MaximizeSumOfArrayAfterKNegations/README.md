### [1005. K 次取反后最大化的数组和](https://leetcode-cn.com/problems/maximize-sum-of-array-after-k-negations/)

#### Description

给你一个整数数组 `nums` 和一个整数 `k` ，按以下方法修改该数组：

选择某个下标 `i` 并将 `nums[i]` 替换为 `-nums[i]` 
重复这个过程恰好 `k` 次。可以多次选择同一个下标` i` 。

以这种方式修改数组后，返回数组 可能的最大和 。

```python
输入：nums = [4,2,3], k = 1
输出：5
解释：选择下标 1 ，nums 变为 [4,-2,3] 
```



#### Solution

算是一道模拟的题目

需要先将数据由绝对值进行排序，排序后，优先将数组里面的负数进行取反

如果余下的`k`是偶数，则可以直接返回结果，如果余下的`k`是奇数，则可以一直在最小的那位进行取反



#### Code

```python
class Solution(object):
    def largestSumAfterKNegations(self, nums, k):
        """
        :type nums: List[int]
        :type k: int
        :rtype: int
        """
        nums = sorted(nums, key=lambda x:abs(x))
        n, res = len(nums), 0
        for i in range(n-1, -1, -1):
            if nums[i] < 0 and k > 0:
                nums[i] = -nums[i]
                k -= 1
        if k % 2 == 0:
            return sum(nums)
        else:
            nums[0] = -nums[0]
        return sum(nums)
```

