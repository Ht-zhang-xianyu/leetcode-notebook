### [39. 组合总和](https://leetcode-cn.com/problems/combination-sum/)

#### Description:

给定一个数组和一个目标数字，找到可以得到目标数字的组合

```python
输入: candidates = [2,3,6,7], target = 7
输出: [[7],[2,2,3]]
```



#### Solution

如果知道是用的回溯法还挺好想的

当组合的和超过`target`时，就跳过那个回溯过程，不然判断是否相等，相等的话就直接添加

设置一个`start`变量，用以控制其前向的流程，保证每次在当前阶段的数可以被取多次





#### Code

```python
class Solution(object):
    def combinationSum(self, candidates, target):
        """
        :type candidates: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        res = list()
        def backTracking(candidates, start, tmp_res):
            # 如果超了 就砍掉
            if sum(tmp_res) > target:
                return 
            # 如果等于就添加
            if sum(tmp_res) == target:
                res.append(tmp_res[:])
                return 
            # 回溯的过程
            for i in range(start, len(candidates)):
                tmp_res.append(candidates[i])
                backTracking(candidates, i, tmp_res)
                tmp_res.pop()
        backTracking(candidates, 0, [])
        return res 
```

