public class Solution {
    public int IslandPerimeter(int[][] grid) {
        var result = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if(grid[i][j] == 1)
                        result += getvalue(grid,i,j);
                }
            }

            return result;
    }
    
    private int getvalue(int[][] gird, int i,int j){
        int result = 4;
        result -= i == 0 ? 0: gird[i-1][j];
        result -= i == gird.Length-1?0:gird[i+1][j];
        result -= j == 0 ?0 :gird[i][j-1];
        result -= j == gird[0].Length-1?0:gird[i][j+1];
        return result;
    }
}


