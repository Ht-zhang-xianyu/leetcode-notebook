# 840. Magic Squares In Grid

A `3 x 3` magic square is a `3 x 3` grid filled with distinct numbers **from** `1` **to** `9` such that each row, column, and both diagonals all have the same sum.

Given a `row x col` `grid` of integers, how many `3 x 3` "magic square" subgrids are there? (Each subgrid is contiguous).

 

**Example 1:**

![img](https://assets.leetcode.com/uploads/2020/09/11/magic_main.jpg)

```
Input: grid = [[4,3,8,4],[9,5,1,9],[2,7,6,2]]
Output: 1
Explanation: 
The following subgrid is a 3 x 3 magic square:

while this one is not:

In total, there is only one magic square inside the given grid.
```

**Example 2:**

```
Input: grid = [[8]]
Output: 0
```

**Example 3:**

```
Input: grid = [[4,4],[3,3]]
Output: 0
```

**Example 4:**

```
Input: grid = [[4,7,8],[9,5,1],[2,3,6]]
Output: 0
```

 

**Constraints:**

- `row == grid.length`
- `col == grid[i].length`
- `1 <= row, col <= 10`
- `0 <= grid[i][j] <= 15`



结题思路，纯数学题，首先3*3 的格子不能有重复的，distinctDigits就是去重的，其次就是判断横向，纵向，斜线是不是和相等。

```c#
public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        
        if(grid.Length < 3 || grid[0].Length < 3)
            return 0;
        int result = 0;
        for(int row = 0;row < grid.Length -2; row++){
            for(int line = 0; line < grid[0].Length-2; line ++){
                if(CountMagic(grid,row,line))
                    result++;
            }
        }
        return result;
        
    }
    
    
   private bool CountMagic(int[][] grid, int i, int j)
    {  
        bool[] distinctDigits = new bool[10];
        for(int k=i;k <= i+2; k++)
        {
            for(int l=j;l <= j+2; l++)
            {
                if(grid[k][l] < 1 || grid[k][l] > 9)
                    return false;
                
                if(distinctDigits[grid[k][l]])
                    return false;
                else
                    distinctDigits[grid[k][l]] = true;
            }
        }        
        
        // Rows
        if( grid[i][j] + grid[i][j+1] + grid[i][j+2] != 15 || grid[i+1][j] + grid[i+1][j+1] + grid[i+1][j+2] != 15 ||
          grid[i+2][j] + grid[i+2][j+1] + grid[i+2][j+2] != 15)
            return false;
        
        // Columns
        if(grid[i][j] + grid[i+1][j] + grid[i+2][j] != 15 || grid[i][j+1] + grid[i+1][j+1] + grid[i+2][j+1] != 15 ||
          grid[i][j+2] + grid[i+1][j+2] + grid[i+2][j+2] != 15)
            return false;
          
         // Diagonals 
        if(grid[i][j] + grid[i+1][j+1] + grid[i+2][j+2] != 15 || grid[i+2][j] + grid[i+1][j+1] + grid[i][j+2] != 15)
            return false;
        
        return true;
    }
}
```

