### [541. 反转字符串 II](https://leetcode-cn.com/problems/reverse-string-ii/)

#### Descripiton 

给定字符串`s`和整数`k`，从字符串开头算起，每计算到`2k`个字符，就反转`2k`字符中的前`k`个

- 如果剩余字符少于 `k` 个，则将剩余字符全部反转。
- 如果剩余字符小于 `2k` 但大于或等于 `k` 个，则反转前 `k` 个字符，其余字符保持原样。

```python
输入：s = "abcdefg", k = 2
输出："bacdfeg"

输入：s = "abcd", k = 2
输出："bacd"
```



#### Solution

感觉该题的难点在于对于下标的处理加上对库函数的结合（要记得`py`中的`reversed`函数）



#### Code

```python
def reverseStr(self, s, k):
  t = list(s)
  for i in range(0, len(t), 2*k):
    t[i:i+k] = reversed(t[i:i+k])
  return "".join(t)
```

