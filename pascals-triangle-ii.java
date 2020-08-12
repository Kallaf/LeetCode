class Solution {
    public List<Integer> getRow(int rowIndex) {
        Integer[] curr = new Integer[rowIndex+1];
        Arrays.fill(curr, 0);
        curr[0] = 1;
        for(int n=0;n<=rowIndex;n++)
        {
            for(int j=n;j>0;j--)
                curr[j] += curr[j-1];
            
        }
        return Arrays.asList(curr);
    }
}
