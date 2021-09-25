### [1143. 最长公共子序列](https://leetcode-cn.com/problems/longest-common-subsequence/)

#### Description

给定两个字符串，获取两个字符串相同的最大共同子串（不需要连续在一起才算）

```python
输入：text1 = "abcde", text2 = "ace" 
输出：3  
解释：最长公共子序列是 "ace" ，它的长度为 3 。
```



#### Solution

设立动态规划的矩阵，定义为到每个位置时的最大子串的长度

分别比较两个字符串的每个字符

1）当某个字符相等时，矩阵内的这个位置等于两个字符分别上个字符的dp值+1

```python
if text1[i] == text2[j]:
    dp[i][j] = dp[i-1][j-1] + 1
```

2）当某个字符不想等时，该位置就等于text1和text2上个位置的最大子串数目

```python
if text1[i] != text2[j]:
    dp[i][j] = max(dp[i-1][j], dp[i][j-1])
```



#### Code

```python
class Solution(object):
    def longestCommonSubsequence(self, text1, text2):
        """
        :type text1: str
        :type text2: str
        :rtype: int
        """
        # 建立动态规划的矩阵
        n, m = len(text1), len(text2)
        dp = [[0] * (n+1) for _ in range(m+1)]

        for i in range(1, n+1):
            for j in range(1, m+1):
                # 如果第一个字符等于第二个字符
                # 由两个字符串的前一位+1
                if text1[i-1] == text2[j-1]:
                    dp[j][i] = dp[j-1][i-1] + 1
                else:
                    # 如果不等，那就取此时text1和text2最大子串
                    dp[j][i] = max(dp[j-1][i], dp[j][i-1])
        return dp[-1][-1]
```



#### Link

类似题目链接：

#### [583. 两个字符串的删除操作](https://leetcode-cn.com/problems/delete-operation-for-two-strings/)