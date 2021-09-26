### [77. 组合](https://leetcode-cn.com/problems/combinations/)

#### Description

给定**n**和**k**,返回**[1, n]**中**k**个数的组合

```python
输入：n = 4, k = 2
输出：
[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]
```



#### Solution

看了题目解析，好像这是道回溯算法的入门题，但是被后面的剪枝操作秀到了，大体上参考的是这份笔记中[回溯题目的模版](https://mp.weixin.qq.com/s/HQG8rdTT5nHhQMWdcqh1Qg)

先确定题目的终止条件，也就如下

```python
if len(tmp) == k:
  res.append(tmp)
  return 
```

然后就是在给定的数字中进行遍历，由于自己重复的元素不符合题解，也就是**[1, 1], [2, 2]** ..所以我们如果按照正常的遍历，也即如下：

```python
for i in range(n):
  tmp.append(i)
  backTracking(n, k)
  tmp.pop()
```

就会出现重复现象，感觉这部分可能是在知道回溯的模版后，这道题比较难的一个点了

然后看大佬的解析，说是这里可以多设置一个**Start**的变量，用以控制我们遍历的范围，所以我们的回溯函数的定义就如下了：

```python
def backTracking(n, k, start):
  '''
  ...
  '''
  for i in range(start, n):
    tmp.append(i)
    backTracking(n, k, i+1)
    tmp.pop()
```

于是组合起来就有了如下的代码



#### Code

```python
class Solution(object):
    def combine(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: List[List[int]]
        """
        # 创建 结果的收纳列表
        res, temp = list(), list()

        def backTracking(n, k, start):
            # 当满足条件时，将当前的列表推进结果列表，返回
            if len(temp) == k:
                res.append(temp[:])
                return 
            for i in range(start, n):
                # 每次推进一个列表
                temp.append(i)
                # 树的遍历
                backTracking(n, k, i+1)
                # 回到上个节点
                temp.pop()
        backTracking(n+1, k, 1)
        return res
```



#### Optim

然后根据其笔记，我发现比较骚的操作是剪枝部分，当给定限定条件时，其实作为遍历整颗N叉树，是会有冗余的情况，例如我们**k==3**，我们遍历到2之后的循环是没有意义的，因为我们即使全部取到，我们的最终元素还是少于3个，所以我们的终止条件可以设置为最起码的可以迭代的起点（这里表述不是特别清楚，待想明白些回来修改）

所以有了剪枝之后的代码

```python
class Solution(object):
    def combine(self, n, k):
        """
        :type n: int
        :type k: int
        :rtype: List[List[int]]
        """
        # 创建 结果的收纳列表
        res, temp = list(), list()

        def backTracking(n, k, start):
            # 当满足条件时，将当前的列表推进结果列表，返回
            if len(temp) == k:
                res.append(temp[:])
                return 
            for i in range(start, n-(k-len(temp))+1):
                # 每次推进一个列表
                temp.append(i)
                # 树的遍历
                backTracking(n, k, i+1)
                # 回到上个节点
                temp.pop()
        backTracking(n+1, k, 1)
        return res
```



#### Link

| 题目                                                         | 难度    |
| ------------------------------------------------------------ | ------- |
| [组合总和3](https://leetcode-cn.com/problems/combination-sum-iii/submissions/) | **Mid** |

