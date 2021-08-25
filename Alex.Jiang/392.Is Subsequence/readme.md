# No.392 Is Subsequence

## Description

Given two strings `s` and `t`, return `true` *if* `s` *is a **subsequence** of* `t`*, or* `false` *otherwise*.

A **subsequence** of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., `"ace"` is a subsequence of `"abcde"` while `"aec"` is not).

 

**Example 1:**

```
Input: s = "abc", t = "ahbgdc"
Output: true
```

**Example 2:**

```
Input: s = "axc", t = "ahbgdc"
Output: false
```

 

**Constraints:**

- `0 <= s.length <= 100`
- `0 <= t.length <= 104`
- `s` and `t` consist only of lowercase English letters.

 

**Follow up:** Suppose there are lots of incoming `s`, say `s1, s2, ..., sk` where `k >= 109`, and you want to check one by one to see if `t` has its subsequence. In this scenario, how would you change your code?



题目要求是子字符串，这里**踩了一个坑**， 比如说 abc 对应 acteb, 虽然都有abc，但是因为后面的顺序不一样，认定不是子字符串。傻傻的我以为只要包含对应的每个字符就行。

解题思路就是用双指针，只要左边的指针走到最后一位且没问题，就肯定是符合子字符串的条件。

Code

```C#
public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int p1 = 0;
        int p2 = 0;
        while (p1 < t.Length && p2 < s.Length)
        {
            if (t[p1] == s[p2])
                p2++;
            p1++;
        }
        return p2 == s.Length;
    }
}
```



