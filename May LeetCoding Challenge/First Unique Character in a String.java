class Solution {
    public int firstUniqChar(String s) {
        int[] count = new int[30];
        Arrays.fill(count,-1);
        char[] chr = s.toCharArray();
        for(int i=0;i<chr.length;i++)
        {
            if(count[chr[i]-'a'] == -1)
                count[chr[i]-'a'] = i;
            else
                count[chr[i]-'a'] = -2;
        }
        boolean flag = true;
        int mn = Integer.MAX_VALUE;
        for(int i=0;i<26;i++)
        {
            if(count[i] >= 0)
            {
                flag = false;
                mn = Math.min(mn,count[i]);
            }
        }
        if(flag)return -1;
        return mn;
    }
}
