class Solution:
    def wordPattern(self, pattern: str, str: str) -> bool:
        s = str.strip().split()
        if len(pattern) != len(s):
            return False
        dc = dict()
        rv = dict()
        for i in range(len(s)):
            if (pattern[i] in dc.keys() and s[i]!=dc[pattern[i]]) or (s[i] in rv.keys() and pattern[i]!=rv[s[i]]):
                return False
            dc[pattern[i]] = s[i]
            rv[s[i]] = pattern[i]
        return True
        
