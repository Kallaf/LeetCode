class Solution {
    private boolean isVowel(char c)
    {
        if(c == 'a' || c == 'A')return true;
        if(c == 'e' || c == 'E')return true;
        if(c == 'i' || c == 'I')return true;
        if(c == 'o' || c == 'O')return true;
        if(c == 'u' || c == 'U')return true;
        return false;
    }
    private String convert(String word,int cnt)
    {
        StringBuilder sb = new StringBuilder();
        char[] ch = word.toCharArray();
        if(isVowel(ch[0]))
        {
            for(int i=0;i<ch.length;i++)
                sb.append(ch[i]);
        }else{
            for(int i=1;i<ch.length;i++)
                sb.append(ch[i]);
            sb.append(ch[0]);
        }
        sb.append('m');
        sb.append('a');
        for(int i=0;i<cnt;i++)
            sb.append('a');
        return sb.toString();
    }
    public String toGoatLatin(String S) {
        String[] sen = S.split(" ");
        String ans = "";
        boolean first = true;
        int cnt = 1;
        for(String word:sen)
        {
            if(first)first = false;
            else ans += " ";
            ans += convert(word,cnt++);
        }
        return ans;
    }
}
