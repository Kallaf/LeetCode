public class Solution {
    Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
        
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        if (map.ContainsKey(s))
            return map[s];
        IList<string> result = new List<string>();
        if (wordDict.Contains(s))
            result.Add(s);
        for (int i = 1; i < s.Length; i++) {
            string left = s.Substring(0, i);
            if (wordDict.Contains(left)) {
                foreach(string ss in WordBreak(s.Substring(i), wordDict)) {
                    result.Add(left+ " " + ss);
                }
            }
        }

        map.Add(s, result);
        return result;
    
    }
}
