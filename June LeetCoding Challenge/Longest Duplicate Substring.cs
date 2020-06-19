public class Solution {
    public int possible(char[] s, int len) {
        long hash = 0;
        int a = 26;
        int n = s.Length;
        long mod = (long)Math.Pow(2, 32);
        for(int i = 0; i < len; ++i) 
            hash = (hash * a + (s[i]-'a')) % mod;

        HashSet<long> set = new HashSet<long>();
        set.Add(hash);
        long global = 1;
        for (int i = 0; i < len; ++i) 
            global = (global * a) % mod;

        for(int start = 1; start < n - len + 1; ++start) {
            hash = (hash * a - (s[start - 1]-'a') * global % mod + mod) % mod;
            hash = (hash + (s[start + len - 1]-'a')) % mod;
            if (set.Contains(hash)) return start;
            set.Add(hash);
        }
        return -1;
    }
    
    public string LongestDupSubstring(string S) {
        char[] s = S.ToCharArray();
        int lo = 1;
        int hi = s.Length;
        while (lo != hi) {
            int mi = lo + (hi - lo) / 2;
            if (possible(s, mi) != -1)
                lo = mi + 1;
            else
                hi = mi;
        }
        int start = possible(s, lo - 1);
        return start != -1 ? S.Substring(start,lo - 1) : "";
    }
}
