class Solution {
    public String convert(String s, int numRows) {
        int n = s.length();
        String[] rows = new String[numRows];
        for(int i=0;i<numRows;i++)
            rows[i] = "";
        for(int i=0,j=0,k=1;i<n;i++)
        {
            rows[j] += s.charAt(i);
            if(numRows > 1)
            {
                j+=k;
                if(j == -1 || j == numRows)
                {
                    k*=-1;
                    j+=2*k;
                }   
            }
        }
        String ans = "";
        for(int i=0;i<numRows;i++)
                ans += rows[i];
        return ans;
    }
}
