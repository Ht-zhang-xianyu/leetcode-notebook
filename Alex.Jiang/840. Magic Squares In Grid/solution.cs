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