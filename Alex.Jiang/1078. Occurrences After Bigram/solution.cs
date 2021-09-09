public class Solution
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        string[] words = text.Split(" ");
        List<string> result = new List<string>();
        if (words.Length < 3)
            return new string[0];
        for (int i = 2; i < words.Length; i++)
        {
            if (words[i - 1] == second && words[i - 2] == first)
                result.Add(words[i]);
        }
        return result.ToArray();
    }
}