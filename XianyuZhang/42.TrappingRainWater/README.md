### [42. 接雨水](https://leetcode-cn.com/problems/trapping-rain-water/)

#### Description

给定柱子高度，问如果下雨时能够承接多少的雨水

```python
输入：height = [0,1,0,2,1,0,1,3,2,1,2,1]
输出：6
解释：上面是由数组 [0,1,0,2,1,0,1,3,2,1,2,1] 表示的高度图，在这种情况下，可以接 6 个单位的雨水（蓝色部分表示雨水）。 
```



#### Solution

每个位子能接多少雨水，都取决于左右最大柱子高度的最小值与当前柱子高度的差

所以有两个数组分别计算说当前柱子的左右最大柱子高度，再结合当前柱子高度，就可以得到对应的值了



#### Code

```python
class Solution(object):
    def trap(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        n = len(height)
        left_max = [0 for _ in range(n)]
        right_max = [0 for _ in range(n)]
        left_max[0] = height[0]
        right_max[-1] = height[-1]
        for i in range(1, n):
            left_max[i] = max(height[i], left_max[i-1])
        for i in range(n-2, -1, -1):
            right_max[i] = max(right_max[i+1], height[i])
        res = 0 
        for i in range(n):
            res += (min(right_max[i], left_max[i]) - height[i])
        return res 
```

