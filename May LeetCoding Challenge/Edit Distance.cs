public class Solution {
    private char[] s1, s2;
    private int[][] memo;
    private int CountOperations(int i,int j)
    {
        if(i==s1.Length)return s2.Length - j;
        if(j==s2.Length)return s1.Length - i;
        
        if(memo[i][j] != -1)return memo[i][j];
        
        if(s1[i] == s2[j])return memo[i][j] = CountOperations(i+1,j+1);
        //Delete
        memo[i][j] = CountOperations(i+1,j);
        //Insert
        memo[i][j] = Math.Min(memo[i][j],CountOperations(i,j+1));
        //Replace
        memo[i][j] = Math.Min(memo[i][j],CountOperations(i+1,j+1));
        memo[i][j]++;
        return memo[i][j];
    }
    public int MinDistance(string word1, string word2) {
        s1 = word1.ToCharArray();
        s2 = word2.ToCharArray();
        memo = new int[s1.Length][];
        for(int i=0;i<s1.Length;i++)
        {
            memo[i] = new int[s2.Length];
            Array.Fill(memo[i],-1);
        }
        return CountOperations(0,0);
    }
}
