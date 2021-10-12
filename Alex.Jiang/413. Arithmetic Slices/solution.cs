public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        if(nums.Length < 3)
            return 0;
        int ans = 0;
        for(int i =0; i< nums.Length-2;i++ ){
            int tmp = 2;
            int dif = nums[i+1] - nums[i];
            int j = i+1;
            while(j < nums.Length-1 && nums[j+1]-nums[j] == dif){
                j++;
                tmp++;
                if(tmp >= 3)
                    ans++;
            }
        }
        return ans;
    }
}