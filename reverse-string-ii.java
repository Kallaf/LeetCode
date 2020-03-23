class Solution {
    public String reverseStr(String s, int k) {
        String reversed = "";
        for(int i=0,j=0;i<s.length();i+=k,j++)
        {
            if(j%2 == 0)
            {
                for(int l=i+Math.min(k,s.length()-i)-1;l>=i;l--)
                    reversed += s.charAt(l);
            }else
                reversed += s.substring(i,i+Math.min(k,s.length()-i));
        }
        return reversed;
    }
}
