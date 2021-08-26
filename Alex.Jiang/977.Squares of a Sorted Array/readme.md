# No 977 Squares of a Sorted Array

## Description

Given an integer array `nums` sorted in **non-decreasing** order, return *an array of **the squares of each number** sorted in non-decreasing order*.

 

**Example 1:**

```
Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
```

**Example 2:**

```
Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
```

 

**Constraints:**

- `1 <= nums.length <= 104`
- `-104 <= nums[i] <= 104`
- `nums` is sorted in **non-decreasing** order.



数组按照大小已经排好序了，然后将每个数平方，再排好序。最开始想着找到正好由负数转正数的那个点，然后左右双指针走，从小到大组出结果。结果也过了。

还有一个思路就是两边的数字最大的一定是整个结果集最大的结果，所以不用找那个中间节点，节省一遍遍历。