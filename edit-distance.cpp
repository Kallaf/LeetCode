class Solution {
    string s1,s2;
    int n,m;
    vector<vector<int>> memo;
    int countOperations(int i,int j)
    {
        if(i==n)return m - j;
        if(j==m)return n - i;
        
        int& res = memo[i][j];
        
        if(res != -1)return memo[i][j];
        
        if(s1[i] == s2[j])return res = countOperations(i+1,j+1);
        //Delete
        res = countOperations(i+1,j);
        //Insert
        res = min(res,countOperations(i,j+1));
        //Replace
        res = min(res,countOperations(i+1,j+1));
        res++;
        return res;
    }
public:
    int minDistance(string word1, string word2) {
        s1 = word1;
        s2 = word2;
        n = s1.length();
        m = s2.length();
        memo.assign(n+2,vector<int>(m+2,-1));
        return countOperations(0,0);
    }
};
