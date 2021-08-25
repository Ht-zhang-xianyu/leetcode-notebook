public class Solution
{
    public int CountPrimeSetBits(int left, int right)
    {
        int result = 0;
        for (int i = left; i <= right; i++)
        {
            int tmp = i;
            int count = 0;
            while (tmp != 0)
            {
                count += tmp % 2;
                tmp /= 2;
            }
            if (IsPrimeNumber(count))
                result++;
        }
        return result;

    }

    public bool IsPrimeNumber(int number)
    {
        if (number == 0 || number == 1)
            return false;
        if (number == 2)
            return true;
        for (int i = 2; i < number / 2 + 1; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}