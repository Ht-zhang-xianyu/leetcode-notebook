# 926. Flip String to Monotone Increasing

- A binary string is monotone increasing if it consists of some number of `0`'s (possibly none), followed by some number of `1`'s (also possibly none).

  You are given a binary string `s`. You can flip `s[i]` changing it from `0` to `1` or from `1` to `0`.

  Return *the minimum number of flips to make* `s` *monotone increasing*.

   

  **Example 1:**

  ```
  Input: s = "00110"
  Output: 1
  Explanation: We flip the last digit to get 00111.
  ```

  **Example 2:**

  ```
  Input: s = "010110"
  Output: 2
  Explanation: We flip to get 011111, or alternatively 000111.
  ```

  **Example 3:**

  ```
  Input: s = "00011000"
  Output: 2
  Explanation: We flip to get 00000000.
  ```

   

  **Constraints:**

  - `1 <= s.length <= 105`
  - `s[i]` is either `'0'` or `'1'`.





## 解题思路

这里考虑动态规划的思路，如果想要复合条件，那某一点前面全部都是0，后面全部都是1。极端思考，到某一个点位，如果他是0，那就看前面所有的1变成0的次数，与所有0变成1的次数加1对比（本身是0，需要也变成1，所以加1），哪个小就用哪个。

所以DP （n）= Math.Min( oneCount(n), zeroCount(n)+1); 







