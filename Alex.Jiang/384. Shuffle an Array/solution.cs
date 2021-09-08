public class Solution
{

    int[] nums;
    Random rand = new Random();

    public Solution(int[] nums)
    {
        this.nums = nums;
    }

    public int[] Reset()
    {
        return this.nums;
    }

    public int[] Shuffle()
    {
        if (this.nums.Length <= 1)
        {
            return this.nums;
        }
        var list = this.nums.ToList();
        var res = new int[this.nums.Length];
        for (var i = 0; i < res.Length; i++)
        {
            var j = rand.Next() % list.Count;
            res[i] = list[j];
            list.RemoveAt(j);
        }
        return res;
    }
}