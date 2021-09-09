## 986 Interval List Intersections

You are given two lists of closed intervals, `firstList` and `secondList`, where `firstList[i] = [starti, endi]` and `secondList[j] = [startj, endj]`. Each list of intervals is pairwise **disjoint** and in **sorted order**.

Return *the intersection of these two interval lists*.

A **closed interval** `[a, b]` (with `a <= b`) denotes the set of real numbers `x` with `a <= x <= b`.

The **intersection** of two closed intervals is a set of real numbers that are either empty or represented as a closed interval. For example, the intersection of `[1, 3]` and `[2, 4]` is `[2, 3]`.

 

**Example 1:**

![img](https://assets.leetcode.com/uploads/2019/01/30/interval1.png)

```
Input: firstList = [[0,2],[5,10],[13,23],[24,25]], secondList = [[1,5],[8,12],[15,24],[25,26]]
Output: [[1,2],[5,5],[8,10],[15,23],[24,24],[25,25]]
```

**Example 2:**

```
Input: firstList = [[1,3],[5,9]], secondList = []
Output: []
```

**Example 3:**

```
Input: firstList = [], secondList = [[4,8],[10,12]]
Output: []
```

**Example 4:**

```
Input: firstList = [[1,7]], secondList = [[3,10]]
Output: [[3,7]]
```

 

**Constraints:**

- `0 <= firstList.length, secondList.length <= 1000`
- `firstList.length + secondList.length >= 1`
- `0 <= starti < endi <= 109`
- `endi < starti+1`
- `0 <= startj < endj <= 109`
- `endj < startj+1`



结题思路

首先由几个条件

- 如果两个数组没有相交，一定没有结果，落后的一方向前走
- 如果相交，取交集结果，还是相对落后的往前走（左比左较小的，或者右比右较小的）
- 如果一方走到头，就可以结束了，后面不存在相交的可能性。

双指针解决：

```C#
public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        int l = 0;
        int r = 0;
        var result = new List<int[]>();
        while(l < firstList.Length && r < secondList.Length){
            int[] first = firstList[l];
            int[] second = secondList[r];
            if(IsCross(first[0],first[1],second[0],second[1])){
                result.Add(new int[]{Math.Max(first[0],second[0]), Math.Min(first[1],second[1])});
                if(first[1] > second[1])
                    r++;
                else
                    l++;
            }else{
                if(first[1] < second[0])
                    l++;
                else
                    r++;
            }
        }
        return result.ToArray();
    }
    
    public bool IsCross(int fleft, int fright, int sleft,int sright){
        if(fright < sleft || sright < fleft)
            return false;
        return true;
    }
}
```

