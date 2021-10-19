# No.386. Lexicographical Numbers

Given an integer `n`, return all the numbers in the range `[1, n]` sorted in lexicographical order.

You must write an algorithm that runs in `O(n)` time and uses `O(1)` extra space. 

 

**Example 1:**

```
Input: n = 13
Output: [1,10,11,12,13,2,3,4,5,6,7,8,9]
```

**Example 2:**

```
Input: n = 2
Output: [1,2]
```

 

**Constraints:**

- `1 <= n <= 5 * 104`



结题思路

深度递归的思路，先乘10向下，直到大于作为退出条件。

Code:

```C#
public class Solution {
    public IList<int> LexicalOrder(int n) {
        var result = new List<int>();
        for(int i = 1; i <= Math.Min(n,9);i++){
            result.Add(i);
            DFS(i*10,n,result);
        }
        return result;
    }
    
    public void DFS(int baseNumber, int n, List<int> result){
        if(baseNumber > n) return;
        for(int i = 0; i <10; i++){
            var tmp = baseNumber + i;
            if(tmp > n) return;
            result.Add(tmp);
            DFS(tmp*10,n,result);
        }
    }
}
```

