public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int result = 0;
        for(int i = 0; i < arr.Length;i++){
            int tmp = arr[i];
            result += tmp;
            for(int j = i+2;j < arr.Length;j+=2){
                tmp += (arr[j]+ arr[j-1]);
                result += tmp;
            }
        }
        return result;
    }
}