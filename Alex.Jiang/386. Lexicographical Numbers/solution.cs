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