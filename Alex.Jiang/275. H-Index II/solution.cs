public class Solution {
    public int HIndex(int[] citations) 
    {
        if (citations == null) return 0;
        
        int  n = citations.Length;
        int left = 0;
        int right = citations.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (citations[mid] < n - mid)
                left = mid + 1;
            else 
                right = mid - 1;
        }
        
        return n - left;
    }
}