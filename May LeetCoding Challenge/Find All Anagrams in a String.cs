public class Solution {
    
    private bool AreEqual(Dictionary<char, int> dic1,Dictionary<char, int> dic2)
    {
        return dic1.Count == dic2.Count && !dic1.Except(dic2).Any();
    }
    
    public IList<int> FindAnagrams(string s, string p) {
        IList<int> res = new List<int>();
        if(p.Length > s.Length)return res;
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for(int i=0;i<p.Length;i++)
        {
            dict1.TryGetValue(s[i], out var count1);
            dict1[s[i]] = count1+1;
            dict2.TryGetValue(p[i], out var count2);
            dict2[p[i]] = count2+1;
        }
        if(AreEqual(dict1,dict2))res.Add(0);
        for(int i=1;i<=s.Length-p.Length;i++)
        {
            dict1[s[i-1]] = dict1[s[i-1]]-1;
            if(dict1[s[i-1]] == 0)dict1.Remove(s[i-1]);
            dict1.TryGetValue(s[i+p.Length-1], out var count);
            dict1[s[i+p.Length-1]] = count+1;
            if(AreEqual(dict1,dict2))res.Add(i);
        }
        return res;
    }
}
