## 1711. Count Good Meals

A **good meal** is a meal that contains **exactly two different food items** with a sum of deliciousness equal to a power of two.

You can pick **any** two different foods to make a good meal.

Given an array of integers `deliciousness` where `deliciousness[i]` is the deliciousness of the `ith` item of food, return *the number of different **good meals** you can make from this list modulo* `109 + 7`.

Note that items with different indices are considered different even if they have the same deliciousness value.

 

**Example 1:**

```
Input: deliciousness = [1,3,5,7,9]
Output: 4
Explanation: The good meals are (1,3), (1,7), (3,5) and, (7,9).
Their respective sums are 4, 8, 8, and 16, all of which are powers of 2.
```

**Example 2:**

```
Input: deliciousness = [1,1,1,3,3,3,7]
Output: 15
Explanation: The good meals are (1,1) with 3 ways, (1,3) with 9 ways, and (1,7) with 3 ways.
```

 

**Constraints:**

- `1 <= deliciousness.length <= 105`
- `0 <= deliciousness[i] <= 220`



## 解题思路

穷举的思路，先计算每个数字在数组中出现的次数，然后计算每个数字与2的n次方的差值，如果存在另一个数字，则将两个数字出现的次数做乘法就可以，比如说数组有3个1，3个3，那他们相互可以组成4，出现的次数是3*3 = 9 次。

这里如果数字本身是对方的target，比如说4个1，他们相互可以组成2，这里计算的时候要特殊判断一下，否则就变成4*4了，而实际上出现的次数是 4 * 3 = 12次。





