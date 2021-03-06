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
        # 得到两个字符串的最大公共子串
        # 判定两个字符串离最大子串的步数，相加就是结果
        return (n - dp[-1][-1]) + (m - dp[-1][-1])
