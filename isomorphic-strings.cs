public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length)return false;
        var sMap = new Dictionary<char, char>();
        var tMap = new Dictionary<char, char>();
        for(int i=0;i<s.Length;i++)
        {
            if(!sMap.ContainsKey(s[i]))sMap.Add(s[i], t[i]);
            else if(sMap[s[i]] != t[i])return false;
            
            if(!tMap.ContainsKey(t[i]))tMap.Add(t[i], s[i]);
            else if(tMap[t[i]] != s[i])return false;
        }
        return true;
    }
}
