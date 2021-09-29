public class Solution {
    public int NumTimesAllBlue(int[] light) {
        int max = -1;
        int result = 0;
        for(int i =0;i<light.Length;i++){
            max = Math.Max(max, light[i]);
            if(max == i+1) result++;
        }
        return result;
    }
}