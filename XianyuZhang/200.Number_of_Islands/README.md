### [200. 岛屿数量](https://leetcode-cn.com/problems/number-of-islands/)

### Description 

给定一个二维矩阵，里面存在 “0”， “1”，即海水与岛屿的内容，要给出里面岛屿的数目



#### Solution-one

深搜的算法：

假设每到一个位置，都是到了二叉树的一个节点。

然后遇到节点为“1”的情况就对我们的岛屿数目自动加一，以及特殊处理。

特殊处理包括：1）将“1”节点给变为“0”。2）查看其相邻节点是否也是“1”，是的话也需要将其转换为“0”，其上下左右的过程可以设想为是二叉树的遍历问题。



#### Code

```python
class Solution(object):
    def numIslands(self, grid):
        """
        :type grid: List[List[str]]
        :rtype: int
        """
        res = 0
        n, m = len(grid), len(grid[0])
        for i in range(m):
            for j in range(n):
                # 遇到 岛屿的情况，添加内容，进行深搜
                if grid[j][i] == '1':
                    res += 1
                    self.dfs(grid, j, i)
        return res 
    
    def dfs(self, grid, j, i):
        # 边界判断
        if i < 0 or j < 0 or i >= len(grid[0]) or j>=len(grid):
            return
        # 如果是海水的话，就退出 
        if grid[j][i] == '0':
            return 
        # 转为海水，然后进行上下左右的深搜
        grid[j][i] = '0'
        self.dfs(grid, j+1, i)
        self.dfs(grid, j, i+1)
        self.dfs(grid, j-1, i)
        self.dfs(grid, j, i-1)
```



