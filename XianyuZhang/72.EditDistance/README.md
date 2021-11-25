### [72. 编辑距离](https://leetcode-cn.com/problems/edit-distance/)

#### Description

给定两个单词，得到一个单词到另一个单词的最少操作数目

```python
输入：word1 = "horse", word2 = "ros"
输出：3
解释：
horse -> rorse (将 'h' 替换为 'r')
rorse -> rose (删除 'r')
rose -> ros (删除 'e')
```



#### Solution

**笔记**：对于字符串的动态规划题目，发现题目构造的`dp`数组

通常是需要比实际的长度多一位，然后计算到某个位置的时候，采用如下的写法

```python
dp = [0 for _ in range(len(text)+1)]
for i in range(i, len(text)+1):
  if text[i-1]:
    dp[i] = ....  dp[i-1]
```

大约有碰到两三道题这么写法自己的接受度比较高，可以参照

至于为什么需要多一位，个人认为是为了说对于第一位跟什么都没有(`""`)的情况进行对比，例如这道题



设定一个二维的子数组，作为`dp`状态，`dp[i][j]`代表着`word1[i]`字符到`word2[j]`字符需要多少步，对于初始状态，也即是当`text1`什么都没有时，到`text2`需要多少次操作，相关的代码如下：

```python
dp = [[0 for _ in range(len(word1)+1)] for _ in range(len(word2) +1)]
# word2 -> word1需要的步数
for i in range(len(word1)+1):
  dp[0][i] = i
# word1 -> word2需要的步数
for j in range(len(word2) + 1):
  dp[j][0] = j
```

然后当到了某个字符时，如果相等，则

```python
dp[i][j] = dp[i-1][j-1]
```

如果不想等，即需要插入，删除，或者替换时，则为上个最少状态增加一步就好了，写为代码就是

```python
dp[i][j] = min(dp[i-1][j-1], dp[i-1][j], dp[i][j-1])+1
```

最终代码成型就是如下情况了



#### Code

```python
class Solution(object):
    def minDistance(self, word1, word2):
        """
        :type word1: str
        :type word2: str
        :rtype: int
        """
        if not word1 or not word2:
            return max(len(word1), len(word2))
        n, m = len(word1), len(word2)
        dp = [[0 for _ in range(m+1)] for _ in range(n+1)]
        for i in range(n+1):
            dp[i][0] = i 
        for j in range(m+1):
            dp[0][j] = j 
        for i in range(1, n+1):
            for j in range(1, m+1):
                if word1[i-1] == word2[j-1]:
                    dp[i][j] = dp[i-1][j-1]
                else:
                    dp[i][j] = min(dp[i-1][j-1], dp[i-1][j], dp[i][j-1]) + 1
        return dp[-1][-1]

```

