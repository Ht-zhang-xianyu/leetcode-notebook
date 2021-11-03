### [322.零钱兑换](https://leetcode-cn.com/problems/coin-change/)

#### Tag

回溯、动态规划



#### Description

有一个数额和一堆零钱，求最少的零钱数凑出数额金币



#### Solution

可以用回溯法，但是会超时

最后用的动态规划，设定一个`arr` 长度等于 `amount+1`

对从`0-amount`每个数值都循环遍历所有的硬币，根据以下的状态转移公式

`dp[i] = min(dp[i-coin]+1, dp[i])`

更新状态， 由此最后一个位置的数值，就是我们所求的最小



#### Code

```python
class Solution(object):
    def coinChange(self, coins, amount):
        """
        :type coins: List[int]
        :type amount: int
        :rtype: int
        """
        coins = sorted(coins)
        dp = [float('inf')] * (amount+1)
        dp[0] = 0
        for i in range(amount+1):
            for coin in coins:
                if i - coin >= 0 and dp[i-coin] >= 0:
                    dp[i] = min(dp[i], dp[i-coin]+1)
                else:
                    continue 
        if dp[-1] != float('inf'):
            return dp[-1]
        return -1 
```

