# 1375 Bulb Switcher III

There is a room with `n` bulbs, numbered from `1` to `n`, arranged in a row from left to right. Initially, all the bulbs are turned off.

At moment `k` (for `k` from `0` to `n - 1`), we turn on the `light[k]` bulb. A bulb **changes color to blue** only if it is on and all the previous bulbs (to the left) are turned on too.

Return the number of moments in which **all turned-on** bulbs **are blue.**

 

**Example 1:**

![img](https://assets.leetcode.com/uploads/2020/02/29/sample_2_1725.png)

```
Input: light = [2,1,3,5,4]
Output: 3
Explanation: All bulbs turned on, are blue at the moment 1, 2 and 4.
```

**Example 2:**

```
Input: light = [3,2,4,1,5]
Output: 2
Explanation: All bulbs turned on, are blue at the moment 3, and 4 (index-0).
```

**Example 3:**

```
Input: light = [4,1,2,3]
Output: 1
Explanation: All bulbs turned on, are blue at the moment 3 (index-0).
Bulb 4th changes to blue at the moment 3.
```

**Example 4:**

```
Input: light = [2,1,4,3,6,5]
Output: 3
```

**Example 5:**

```
Input: light = [1,2,3,4,5,6]
Output: 6
```

 

**Constraints:**

- `n == light.length`
- `1 <= n <= 5 * 104`
- `light` is a permutation of the numbers in the range `[1, n]`



结题思路：

这道题利用一下整数的特性，连续性。要求是如果点亮第k个灯泡，那前面k-1如果都亮了，那就都变成蓝色。如果k-1个灯泡都亮了，那当前点亮的灯泡最大的index 比如跟k相同才行。举个例子

2,1,3

当点亮1号灯泡时，一共点亮了2个灯泡，最大的灯泡编号是2，那肯定是1,2被点亮了，因为整数连续，不可能点亮了两个，还不是1,2 号。类似同理。

