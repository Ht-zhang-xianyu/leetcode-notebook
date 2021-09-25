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
