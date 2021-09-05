### [56. 合并区间](https://leetcode-cn.com/problems/merge-intervals/)

#### Description

将二维数组的区间合并，成为有序的区间



#### Solution

准备一个res数组，先将数组根据第一位元素的大小进行排序，排序后将每个数组的第一位跟前一位的第二位比，如果超过，就直接添加到res数组，如果没有超过，比较第二位是哪个数组大，更新res数组。



#### Code

```python
class Solution(object):
    def merge(self, intervals):
        """
        :type intervals: List[List[int]]
        :rtype: List[List[int]]
        """
        # 根据第一位的元素进行排序
        intervals = sorted(intervals, key=lambda x:x[0])
        res = list()
        for i, num in enumerate(intervals):
            # 处理第一个元素 
            # 比较新元素的第一位跟已经添加元素的第二位
            if not res or res[-1][1] < num[0]:
                res.append(num)
            else:
                # 更新已经添加数组的第二位
                res[-1][1] = max(res[-1][1], num[1])
        return res 
```

