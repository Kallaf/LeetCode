public class Solution {
    public string FrequencySort(string s) {
        char[] symbol = new char[128];
        int[] count = new int[128];
        foreach(char c in s)count[c]++;
        for(int i=0;i<128;i++)
            symbol[i] = (char)(i);
        Array.Sort(count,symbol);
        char[] ans = new char[s.Length];
        int k = 0;
        for(int i=127;i>0&&count[i]>0;i--)
        {
            for(int j=0;j<count[i];j++)
                ans[k++] = symbol[i];
        }
        return new String(ans);
    }
}
