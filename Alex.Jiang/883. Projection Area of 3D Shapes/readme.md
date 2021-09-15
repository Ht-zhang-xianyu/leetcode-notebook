# 883. Projection Area of 3D Shapes

You are given an `n x n` `grid` where we place some `1 x 1 x 1` cubes that are axis-aligned with the `x`, `y`, and `z` axes.

Each value `v = grid[i][j]` represents a tower of `v` cubes placed on top of the cell `(i, j)`.

We view the projection of these cubes onto the `xy`, `yz`, and `zx` planes.

A **projection** is like a shadow, that maps our **3-dimensional** figure to a **2-dimensional** plane. We are viewing the "shadow" when looking at the cubes from the top, the front, and the side.

Return *the total area of all three projections*.

 

**Example 1:**

![img](https://s3-lc-upload.s3.amazonaws.com/uploads/2018/08/02/shadow.png)

```
Input: grid = [[1,2],[3,4]]
Output: 17
Explanation: Here are the three projections ("shadows") of the shape made with each axis-aligned plane.
```

**Example 2:**

```
Input: grid = [[2]]
Output: 5
```

**Example 3:**

```
Input: grid = [[1,0],[0,2]]
Output: 8
```

**Example 4:**

```
Input: grid = [[1,1,1],[1,0,1],[1,1,1]]
Output: 14
```

**Example 5:**

```
Input: grid = [[2,2,2],[2,1,2],[2,2,2]]
Output: 21
```

 

**Constraints:**

- `n == grid.length`
- `n == grid[i].length`
- `1 <= n <= 50`
- `0 <= grid[i][j] <= 50`



结题思路：

数学问题，用那种三维模型举例，首先xy >0, 那俯视图一定是一个格子的面积，则面积+1，前后视图，每一个列的最大面积取决于它的高度.

```C#
public class Solution {
    public int ProjectionArea(int[][] grid) {
        int n = grid.Length;
        int ans = 0;
        for(int i = 0; i< n; i++){
            int maxRow = 0;
            int maxCol = 0;
            for(int j = 0; j<n;++j){
                if(grid[i][j] > 0) ans++;
                    maxRow = maxRow > grid[i][j] ? maxRow: grid[i][j];
                    maxCol = maxCol > grid[j][i] ? maxCol: grid[j][i];
            }
            ans += maxRow + maxCol;
        }
        return ans;
    }
}
```
