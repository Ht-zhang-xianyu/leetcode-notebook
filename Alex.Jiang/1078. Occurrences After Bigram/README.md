## 1078. Occurrences After Bigram

Given two strings `first` and `second`, consider occurrences in some text of the form `"first second third"`, where `second` comes immediately after `first`, and `third` comes immediately after `second`.

Return *an array of all the words* `third` *for each occurrence of* `"first second third"`.

 

**Example 1:**

```
Input: text = "alice is a good girl she is a good student", first = "a", second = "good"
Output: ["girl","student"]
```

**Example 2:**

```
Input: text = "we will we will rock you", first = "we", second = "will"
Output: ["we","rock"]
```

 

**Constraints:**

- `1 <= text.length <= 1000`
- `text` consists of lowercase English letters and spaces.
- All the words in `text` a separated by **a single space**.
- `1 <= first.length, second.length <= 10`
- `first` and `second` consist of lowercase English letters.



## 结题思路

这个就拆成字符串数组，然后匹配就行。

```c#
public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        string[] words = text.Split(" ");
        List<string> result = new List<string>();
        if(words.Length < 3)
            return new string[0];
        for(int i = 2; i < words.Length;i++)
        {
            if(words[i-1] == second && words[i-2] == first)
                result.Add(words[i]);
        }
        return result.ToArray();
    }
}
```



