# No.1566. Detect Pattern of Length M Repeated K or More Times

## Description

Given an array of positive integers `arr`, find a pattern of length `m` that is repeated `k` or more times.

A **pattern** is a subarray (consecutive sub-sequence) that consists of one or more values, repeated multiple times **consecutively** without overlapping. A pattern is defined by its length and the number of repetitions.

Return `true` *if there exists a pattern of length* `m` *that is repeated* `k` *or more times, otherwise return* `false`.

 

**Example 1:**

```
Input: arr = [1,2,4,4,4,4], m = 1, k = 3
Output: true
Explanation: The pattern (4) of length 1 is repeated 4 consecutive times. Notice that pattern can be repeated k or more times but not less.
```

**Example 2:**

```
Input: arr = [1,2,1,2,1,1,1,3], m = 2, k = 2
Output: true
Explanation: The pattern (1,2) of length 2 is repeated 2 consecutive times. Another valid pattern (2,1) is also repeated 2 times.
```

**Example 3:**

```
Input: arr = [1,2,1,2,1,3], m = 2, k = 3
Output: false
Explanation: The pattern (1,2) is of length 2 but is repeated only 2 times. There is no pattern of length 2 that is repeated 3 or more times.
```

**Example 4:**

```
Input: arr = [1,2,3,1,2], m = 2, k = 2
Output: false
Explanation: Notice that the pattern (1,2) exists twice but not consecutively, so it doesn't count.
```

**Example 5:**

```
Input: arr = [2,2,2,2], m = 2, k = 3
Output: false
Explanation: The only pattern of length 2 is (2,2) however it's repeated only twice. Notice that we do not count overlapping repetitions.
```

 

**Constraints:**

- `2 <= arr.length <= 100`
- `1 <= arr[i] <= 100`
- `1 <= m <= 100`
- `2 <= k <= 100`



说下思路，比如说m=2, k=3, 那就是从某处开始，长度为2的数字重复三次，计数器可以不用按照k来，按照k*m 也就是6来，从某点开始num[i] = num[i+2]就可以，只要是一直重复的那这个条件就生效，一直遍历到满足条件就可以。

Code

```C#
public class Solution
{
    public bool ContainsPattern(int[] arr, int m, int k)
    {
        int count = 0;
        for (int i = 0; i + m < arr.Length; i++)
        {
            if (arr[i] == arr[i + m])
                count++;
            else
                count = 0;

            if (count == (k - 1) * m)
                return true;
        }
        return false;
    }


}
```



