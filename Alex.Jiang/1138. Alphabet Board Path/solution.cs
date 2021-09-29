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