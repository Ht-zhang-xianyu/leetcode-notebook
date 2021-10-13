### [40. 组合总和 II](https://leetcode-cn.com/problems/combination-sum-ii/)

#### Description

给定数组和目标值，得到可以使数字和等于目标值的组合，但不可以重复

```python
输入: candidates = [10,1,2,7,6,1,5], target = 8,
输出:
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]
```



#### Solution

一开始以为是容易的，写了段跟39题类似的代码，后来发现并不是...

难在原始数组里有两个`1`，如果不排序，会出现两个`1,6,1`的组合，但是要求不能重复

所以可能是需要剪枝

剪枝的思路是参考的[这篇文章](https://leetcode-cn.com/problems/combination-sum-ii/solution/hui-su-suan-fa-jian-zhi-python-dai-ma-java-dai-m-3/225211)

先对数组进行一个排序，用了下标`i`和`start`变量做文章，

当我们选定了一个值作为当前的锚点，当`i`大于`start`且重复时，我们就跳过，这样可以保证在树的同一层级别时不会出现重复，且由于有`i`和`start`的限制，我们可以保证，在不同级的遍历时，相同元素可以被涵盖到



#### Code

```python
class Solution(object):
    def combinationSum2(self, candidates, target):
        """
        :type candidates: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        res = list()
        # 由于要求相应的没有重复，所以需要排序一下，方便驱虫
        candidates = sorted(candidates)

        def backTracking(candidates, tmp_res, start):
            # 当组合和大于目标时，跳过
            if sum(tmp_res) > target:
                return 
            # 当组合等于目标且没有重复时，添加
            if sum(tmp_res) == target and tmp_res not in res:
                res.append(tmp_res[:])
                return 
            for i in range(start, len(candidates)):
                # 剪枝，用以剪掉同级的重复元素
                if i > start and candidates[i] == candidates[i-1]:
                    continue 
                tmp_res.append(candidates[i])
                backTracking(candidates, tmp_res, i+1)
                tmp_res.pop()
        backTracking(candidates, [], 0)
        return res 
```

