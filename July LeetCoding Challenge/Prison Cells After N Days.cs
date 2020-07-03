public class Solution {
    private int[] CharToArray(char c)
    {
        int[] cells = new int[8];
        for(int i=7;i>=0;i--)
        {
            cells[i] = c&1;
            c>>=1;
        }
        return cells;
    }
    
    private char ArrayToChar(int[] cells)
    {
        char c = (char)0;
        for(int i=0;i<8;i++)
        {
            c<<=1;
            c += (char)cells[i];
        }
        return c;
    }
    
    private void ChangeState(int[] cells)
    {
        int[] temp = new int[8];
        temp[0] = temp[7] = 0;
        for(int i=1;i<7;i++){
            temp[i] = cells[i-1] == cells[i+1] ? 1:0;
        }
        for(int i=0;i<8;i++)
            cells[i] = temp[i];
    }
    
    public int[] PrisonAfterNDays(int[] cells, int N) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        List<char> arr = new List<char>();
        for(int i=0;i<N;i++)
        {
            char c = ArrayToChar(cells);
            if(dict.ContainsKey(c))
            {
                int m = dict[c];
                int n = arr.Count - m;
                return CharToArray(arr[m + ((N-m) % n)]);
            }
            dict.Add(c,i);
            arr.Add(c);
            ChangeState(cells);
        }
        return cells;
    }
}
