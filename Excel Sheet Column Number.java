class Solution {
    public int titleToNumber(String s) {
        char[] ch = s.toCharArray();
        int ans = 0;
        for(int i=0;i<ch.length;i++)
        {
            ans *= 26;
            ans += ch[i] - 'A' + 1;
        }
        return ans;
    }
}
