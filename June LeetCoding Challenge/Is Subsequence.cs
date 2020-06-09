public class Solution {
    public bool IsSubsequence(string s, string t) {
        int idx = 0;
        foreach(char c in t.ToCharArray())
        {
            if(idx == s.Length)
                return true;
            if(c == s[idx])
                idx++;
        }
        return idx == s.Length;
    }
}
