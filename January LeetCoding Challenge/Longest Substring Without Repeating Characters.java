class Solution {
    public int lengthOfLongestSubstring(String s) {
        int[] lastOcurrance = new int[300];
        for(int i=0;i<300;i++)lastOcurrance[i] = -1;
        char[] ch = s.toCharArray();
        int max = 0,len = 0;
        for(int i=0;i<ch.length;i++)
        {
            int dis = i - lastOcurrance[ch[i]];
            if(dis <= len)len = dis;
            else len++;
            max = Math.max(max,len);
            lastOcurrance[ch[i]] = i;
        }
        return max;
    }
}
