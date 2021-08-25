# No 724 Find Pivot Index

## Description

Given an array of integers `nums`, calculate the **pivot index** of this array.

The **pivot index** is the index where the sum of all the numbers **strictly** to the left of the index is equal to the sum of all the numbers **strictly** to the index's right.

If the index is on the left edge of the array, then the left sum is `0` because there are no elements to the left. This also applies to the right edge of the array.

Return *the **leftmost pivot index***. If no such index exists, return -1.

 

**Example 1:**

```
Input: nums = [1,7,3,6,5,6]
Output: 3
Explanation:
The pivot index is 3.
Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
Right sum = nums[4] + nums[5] = 5 + 6 = 11
```

**Example 2:**

```
Input: nums = [1,2,3]
Output: -1
Explanation:
There is no index that satisfies the conditions in the problem statement.
```

**Example 3:**

```
Input: nums = [2,1,-1]
Output: 0
Explanation:
The pivot index is 0.
Left sum = 0 (no elements to the left of index 0)
Right sum = nums[1] + nums[2] = 1 + -1 = 0
```

 

**Constraints:**

- `1 <= nums.length <= 104`
- `-1000 <= nums[i] <= 1000`



找到一个中间数，左边的和等于右边的和。第一个思路想着双指针，**左边小左边向右移，右边小右边往左移** , 但是忘记了他会有负数，这时候如果一路都是负数，那动的一边一直移动了，也找不到解，最简答的就是[-1，-1，-1，-2]这种，按照双指针就不知道动哪边了。



实际思路还是全部求和，然后从左往右走，条件就是sum = 2 * leftsum + 当前值（leftsum = rightsum），变形就是leftsum = sum -leftsum - 当前值。

Code:

```c#
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int sum = 0;
        int leftsum = 0;
        foreach (var n in nums)
        {
            sum += n;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftsum == sum - leftsum - nums[i])
                return i;
            leftsum += nums[i];
        }
        return -1;
    }
}
```

