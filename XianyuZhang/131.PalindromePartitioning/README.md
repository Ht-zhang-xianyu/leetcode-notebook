### [131. 分割回文串](https://leetcode-cn.com/problems/palindrome-partitioning/)

#### Description

给定字符串`s`，分割子串，使得每个子串都是回文子串



#### Solution

这道题也是看了很多题解才看懂个大概

难点在于说 如何截取子串，参考比较多是这位[大佬的资料](https://programmercarl.com/0131.%E5%88%86%E5%89%B2%E5%9B%9E%E6%96%87%E4%B8%B2.html#%E5%9B%9E%E6%BA%AF%E4%B8%89%E9%83%A8%E6%9B%B2)

可以使用`start`作为截取的起初，在`for`循环后，将下标与`start`结合，`s[start: i+1]`作为截取的子串，而回文子串，采用如下就可以判断`s == s[::-1]`，故而可以每次截取子串后，判断是否为回文，如果是回文，添加到`tmp_res`中，进行下个组合的判断，如果不是回文，则不要跳过当前循环

回溯的主要逻辑如下

```python
def backTrack(s, start):
  if ''.join(tmp_res) == s:
    res.append(tmp_res)
    return 
  for i in range(start, len(s)):
    tmp_s = s[start: i+1]
    if tmp_s == tmp_s[::-1]:
      tmp_res.append(tmp_res)
    else:
    	continue 
    backTrack(s, i+1)
    tmp_res.pop()
```



#### Code

```python
class Solution(object):
    def partition(self, s):
        """
        :type s: str
        :rtype: List[List[str]]
        """
        tmp_res, res = list(), list()
        def backTracking(s, start):
            if ''.join(tmp_res) == s:
                res.append(tmp_res[:])
                return 
            for i in range(start, len(s)):
                tmp = s[start: i+1]
                if tmp == tmp[::-1]:
                    tmp_res.append(tmp)
                else:
                    continue 
                backTracking(s, i+1)
                tmp_res.pop()
        backTracking(s, 0)
        return res 
```

