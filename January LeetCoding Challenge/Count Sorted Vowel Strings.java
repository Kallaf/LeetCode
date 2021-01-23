class Solution {
    private static int [][] count;
    static{
        count = new int[51][];
        for(int i=0;i<=50;i++)
            count[i] = new int[7];
        for(int j=1;j<=5;j++)
            count[0][j] = 1;
        for(int i=1;i<=50;i++)
            for(int j=1;j<=5;j++)
                count[i][j] = count[i-1][j] + count[i][j-1];
            
    }
    public int countVowelStrings(int n) {
        return count[n][5];
    }
}
