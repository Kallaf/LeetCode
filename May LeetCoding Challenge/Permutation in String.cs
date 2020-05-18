public class Solution {
    
    private bool AreEqual(Dictionary<char, int> dic1,Dictionary<char, int> dic2)
    {
        return dic1.Count == dic2.Count && !dic1.Except(dic2).Any();
    }
    
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)return false;
        Dictionary<char, int> dict1 = new Dictionary<char, int>();
        Dictionary<char, int> dict2 = new Dictionary<char, int>();
        for(int i=0;i<s1.Length;i++)
        {
            dict1.TryGetValue(s2[i], out var count1);
            dict1[s2[i]] = count1+1;
            dict2.TryGetValue(s1[i], out var count2);
            dict2[s1[i]] = count2+1;
        }
        if(AreEqual(dict1,dict2))return true;
        for(int i=1;i<=s2.Length-s1.Length;i++)
        {
            dict1[s2[i-1]] = dict1[s2[i-1]]-1;
            if(dict1[s2[i-1]] == 0)dict1.Remove(s2[i-1]);
            dict1.TryGetValue(s2[i+s1.Length-1], out var count);
            dict1[s2[i+s1.Length-1]] = count+1;
            if(AreEqual(dict1,dict2))return true;
        }
        return false;
    }
}
