### [剑指 Offer 38. 字符串的排列](https://leetcode-cn.com/problems/zi-fu-chuan-de-pai-lie-lcof/)

#### Description

输入一个字符串，打印所有字符串的排列，但里面不能存在重复元素

示例:

```python
输入：s = "abc"
输出：["abc","acb","bac","bca","cab","cba"]
```



#### Solution

可见答案中，存在`bac`的解答，就是对顺序是不要求的

此时如果按照常规的`start`解法，会有问题（见第一种），即结果会出现说只能出现`a`起始的字符串排列，不符合题意

似乎需要 不传入`start`的解法（第二种），但是此时也有另外的问题，例如会出现`aab`这种也不合理的解法

```python
# 第一种
for i in range(start, len(s)):
# 第二种
for i in range(len(s)):
```



此时可以考虑构造一个辅助的数组`visited`，用以法2时，我们来确定说经过路径的唯一性，当遍历到该元素，其没有被用过时，我们添加该元素，当该元素被用过了，我们跳过就好了，具体解法可以看代码



#### Code

```python
class Solution(object):
    def permutation(self, s):
        """
        :type s: str
        :rtype: List[str]
        """
        res, tmp_res = [], []
        visited = [False for _ in range(len(s))]
        def backTracking(s):
            if len(tmp_res) == len(s) and ''.join(tmp_res) not in res:
                res.append(''.join(tmp_res))
                return 
            for i in range(len(s)):
                if not visited[i]:
                    visited[i] = True
                    tmp_res.append(s[i])
                    backTracking(s)
                    visited[i] = False 
                    tmp_res.pop()   
                else:
                    continue 
        backTracking(s)
        return res 
```

