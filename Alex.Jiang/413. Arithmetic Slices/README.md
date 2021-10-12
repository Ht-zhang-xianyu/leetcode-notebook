# 413. Arithmetic Slices

An integer array is called arithmetic if it consists of **at least three elements** and if the difference between any two consecutive elements is the same.

- For example, `[1,3,5,7,9]`, `[7,7,7,7]`, and `[3,-1,-5,-9]` are arithmetic sequences.

Given an integer array `nums`, return *the number of arithmetic **subarrays** of* `nums`.

A **subarray** is a contiguous subsequence of the array.

 

**Example 1:**

```
Input: nums = [1,2,3,4]
Output: 3
Explanation: We have 3 arithmetic slices in nums: [1, 2, 3], [2, 3, 4] and [1,2,3,4] itself.
```

**Example 2:**

```
Input: nums = [1]
Output: 0
```

 

**Constraints:**

- `1 <= nums.length <= 5000`
- `-1000 <= nums[i] <= 1000`



## 解题思路

这个已经有很多设置好的条件了：

- 数组时连续递增的，不需要排序
- 求解必须是子数组，意味着不用夸位置找
- 步长一致，直接向后遍历其实就可以了。



选取数组的一个点i，向后遍历a[i+1] - a[i] = dif 就一直向后，长度大于3就意味着有一个子数组，如果满足条件的长度是6，那就有4个结果集。O(N2)的算法。

```c#
public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        if(nums.Length < 3)
            return 0;
        int ans = 0;
        for(int i =0; i< nums.Length-2;i++ ){
            int tmp = 2;
            int dif = nums[i+1] - nums[i];
            int j = i+1;
            while(j < nums.Length-1 && nums[j+1]-nums[j] == dif){
                j++;
                tmp++;
                if(tmp >= 3)
                    ans++;
            }
        }
        return ans;
    }
}
```

