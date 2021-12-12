public class Solution {
    public int CountPairs(int[] deliciousness) {
        long result = 0;
        Dictionary<int, long> nums = new Dictionary<int,long>();
        foreach(var i in deliciousness){
            if(nums.ContainsKey(i))
                nums[i] = nums[i] + 1;
            else
                nums[i] = 1;
        }
        
        foreach(var nkv in nums){
            int power = 1;
            for(int i = 0 ; i < 22; i++){
                int target = power - nkv.Key;
                if(nums.ContainsKey(target)){
                    if(target != nkv.Key)
                        result += (nums[target] * nkv.Value);
                    else
                        result += nkv.Value * (nkv.Value - 1);
                }
                power *= 2;
            }
        }
        
        return (int)(result / 2);
    }
}