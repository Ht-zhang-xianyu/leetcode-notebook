public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        int digit = 1;
        long mod = 1000000000 + 7;
        long sum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i == digit * 2) digit = i;
            sum = (sum * digit * 2) + i;
            sum %= mod;
        }
        return (int)sum;
    }
}