class Solution {
    public int longestPalindrome(String s) {
        boolean odd  = false;
        int[] cnt = new int[100];
        char[] ch = s.toCharArray();
        for(int i=0;i<ch.length;i++)
            cnt[ch[i]-'A']++;
        int res = 0;
        for(int i=0;i<100;i++)
        {
            if(cnt[i] % 2 == 1)
            {
                odd = true;
                cnt[i]--;
            }
            res += cnt[i];
        }
        return res + (odd?1:0);
    }
}
