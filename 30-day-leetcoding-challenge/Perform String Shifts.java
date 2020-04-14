class Solution {
    private char[] str;
    private void rotate(int l,int r)
    {
        int n = r-l;
        for(int i=0;i<n/2;i++)
        {
            char temp = this.str[l+i];
            this.str[l+i] = this.str[r-1-i];
            this.str[r-1-i] = temp;
        }
    }
    public String stringShift(String s, int[][] shift) {
        this.str = s.toCharArray();
        int totalShift = 0;
        int n = this.str.length;
        for(int[] arr:shift)
        {
            if(arr[0] == 1)
                totalShift = (totalShift + arr[1]) % n;
            else
                totalShift = (totalShift + n - arr[1]) % n;
        }
        rotate(0,n);
        rotate(0,totalShift);
        rotate(totalShift,n);
        return new String(this.str);
    }
}
