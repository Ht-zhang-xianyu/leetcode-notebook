public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int p1 = 0;
        int p2 = 0;
        while (p1 < t.Length && p2 < s.Length)
        {
            if (t[p1] == s[p2])
                p2++;
            p1++;
        }
        return p2 == s.Length;
    }
}