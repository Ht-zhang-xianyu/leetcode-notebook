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