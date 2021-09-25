### [583. 两个字符串的删除操作](https://leetcode-cn.com/problems/delete-operation-for-two-strings/)

#### Description

给定两个word1和word2，得到使两个字符串相同所需的最小步数，每步可以删除任意一个字符串中的一个字符

##### exp:

```python
输入: "sea", "eat"
输出: 2
解释: 第一步将"sea"变为"ea"，第二步将"eat"变为"ea"
```



#### Solution

其实可以看作是两个单词到最大公共子串的步数之和，最长公共子串可以参考另一个[题解](https://github.com/Ht-zhang-xianyu/leetcode-notebook/tree/main/XianyuZhang/1143.LongestCommonSubsequence)

得到最长公共子串时，得到两个字符串的长度减掉最长公共子串就可以了



##### Code

```python
class Solution(object):
    def minDistance(self, word1, word2):
        """
        :type word1: str
        :type word2: str
        :rtype: int
        """
        n, m = len(word1), len(word2)
        dp = [[0] * (n+1) for i in range(m+1)]
        for i in range(1, m+1):
            for j in range(1, n+1):
                if word1[j-1] == word2[i-1]:
                    dp[i][j] = dp[i-1][j-1] + 1
                else:
                    dp[i][j] = max(dp[i-1][j], dp[i][j-1])
        return (n - dp[-1][-1]) + (m - dp[-1][-1])
```



#### Link

相似题目的链接

[最长公共子序列](https://leetcode-cn.com/problems/longest-common-subsequence/)

