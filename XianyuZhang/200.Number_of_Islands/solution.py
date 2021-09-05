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
