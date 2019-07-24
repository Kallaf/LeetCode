public class Solution {
    public int TitleToNumber(string s) {
        int colNum = 0;
        for(int i=s.Length-1,j=0;i>=0;i--,j++)
            colNum += (s[i]-'A'+1) * (int)Math.Pow(26,j);
        return colNum;
    }
}
