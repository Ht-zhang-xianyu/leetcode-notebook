### [3. 无重复字符的最长子串](https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/)

#### Description

给定字符串`s`，找出不含有重复字符的最长子串长度

```python
输入: s = "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
  
输入: s = "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
```



#### Solution

采用双指针`left right`，当`right`指示的字符没有在前面的字符串前，增加一个计数，否则，`left`指针前向一步直到当前的字符没有在特定字符串中



#### Code

```python
class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        if not s:
            return 0
        left, right = 0, 0
        res = 1
        s = list(s)
        while right < len(s):
            while right < len(s) and s[right] not in s[left:right]:
                res = max(res, right-left+1)
                right += 1
            while left < right and right < len(s) and s[right] in s[left:right]:
                left += 1
        return res 
```

