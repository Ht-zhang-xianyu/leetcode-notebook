### [46. 全排列](https://leetcode-cn.com/problems/permutations/)

#### Description

给定一个不含重复数字的数组 `nums` ，返回其 **所有可能的全排列** 。你可以 **按任意顺序** 返回答案。



#### Solution

当成是N叉树的遍历，设置大的列表`res`用来返回，设置小的列表`tmp`用来存储不同的回溯结果。

需要注意的：

遍历整个`nums`列表的时候，当那个数字出现在`tmp`列表的时候，就跳过

列表的添加需要用`list[:]`的形式

其他的就采用回溯的结构框架

```python
res = list()
def backTracking(nums, tmp):
  if 设立的条件：
  	res.append(tmp)
    return 
  for num in nums:
    节点的操作(tmp.append(num))
    backTracking(nums, tmp)
    撤销节点的操作(tmp.pop())
```



#### Code

```python
class Solution(object):
    def permute(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        res = list()

        def backTracking(nums, tmp):
            # 终止条件
            if len(tmp) == len(nums):
                res.append(tmp[:])
                return
            for i, num in enumerate(nums):
                # 由于是顺序遍历，所以去除掉前面的已经添加的部分
                if num in tmp:
                    continue
                # 路径选择
                tmp.append(num)
                # 回溯
                backTracking(nums, tmp)
                # 回退到父节点
                tmp.pop()
        backTracking(nums, [])
        return res
```



#### Link

| 题目                                                         | 难度    |
| ------------------------------------------------------------ | ------- |
| [组合总和3](https://leetcode-cn.com/problems/combination-sum-iii/submissions/) | **Mid** |
| [组合](https://leetcode-cn.com/problems/combinations/)       | **Mid** |

