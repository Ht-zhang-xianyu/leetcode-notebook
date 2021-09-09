public class Solution
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        int l = 0;
        int r = 0;
        var result = new List<int[]>();
        while (l < firstList.Length && r < secondList.Length)
        {
            int[] first = firstList[l];
            int[] second = secondList[r];
            if (IsCross(first[0], first[1], second[0], second[1]))
            {
                result.Add(new int[] { Math.Max(first[0], second[0]), Math.Min(first[1], second[1]) });
                if (first[1] > second[1])
                    r++;
                else
                    l++;
            }
            else
            {
                if (first[1] < second[0])
                    l++;
                else
                    r++;
            }
        }
        return result.ToArray();
    }

    public bool IsCross(int fleft, int fright, int sleft, int sright)
    {
        if (fright < sleft || sright < fleft)
            return false;
        return true;
    }
}