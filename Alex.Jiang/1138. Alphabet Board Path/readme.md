# 1138. Alphabet Board Path

On an alphabet board, we start at position `(0, 0)`, corresponding to character `board[0][0]`.

Here, `board = ["abcde", "fghij", "klmno", "pqrst", "uvwxy", "z"]`, as shown in the diagram below.

![img](https://assets.leetcode.com/uploads/2019/07/28/azboard.png)

We may make the following moves:

- `'U'` moves our position up one row, if the position exists on the board;
- `'D'` moves our position down one row, if the position exists on the board;
- `'L'` moves our position left one column, if the position exists on the board;
- `'R'` moves our position right one column, if the position exists on the board;
- `'!'` adds the character `board[r][c]` at our current position `(r, c)` to the answer.

(Here, the only positions that exist on the board are positions with letters on them.)

Return a sequence of moves that makes our answer equal to `target` in the minimum number of moves. You may return any path that does so.

 

**Example 1:**

```
Input: target = "leet"
Output: "DDR!UURRR!!DDD!"
```

**Example 2:**

```
Input: target = "code"
Output: "RR!DDRR!UUL!R!"
```

 

**Constraints:**

- `1 <= target.length <= 100`
- `target` consists only of English lowercase letters.



结题思路

Code

```C#
public class Solution {
    public string AlphabetBoardPath(string target) {
        var sb = new StringBuilder();
        (int x, int y) pos = (0, 0);
        for (int i=0; i<target.Length; i++)
        {
            var nextPos = GetSymbolPosition(target[i]);
            if (pos.x == 5 && nextPos.x != 5) // special rule for 'z'
            {
                sb.Append('U');
                pos.x--;
            }
            
            while (pos.y != nextPos.y)
            {
                sb.Append(pos.y < nextPos.y ? 'R' : 'L');
                pos.y += pos.y < nextPos.y ? 1 : -1;
            }
            
            while (pos.x != nextPos.x)
            {
                sb.Append(pos.x < nextPos.x ? 'D' : 'U');
                pos.x += pos.x < nextPos.x ? 1 : -1;
            }
            sb.Append('!');
        }
        return sb.ToString();
    }
    
    (int x, int y) GetSymbolPosition(char symbol)
        => ((symbol-'a')/5, (symbol-'a')%5);
}
```



这里面求字符的坐标比较简单，a对应是0,0 a的字节码是97，根据这个特性，每排5个，就可以直接求出对应字母的坐标。

比较坑的是Z是独立的一行，只有自己，如果从某个点移动到z，例如y到z，应该先平行移动，然后在移动行，所以遍历的时候，先判断要左右移动，在判断上下移动就没问题了。而且z是个特殊点位，如果从z往别的位置移动，应该先上去，在移动，所以有个硬条件。

