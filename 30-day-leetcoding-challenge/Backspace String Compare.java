class Solution {
    public boolean backspaceCompare(String S, String T) {
        int delS = 0,delT = 0;
        char[] s = S.toCharArray();
        char[] t = T.toCharArray();
        for(int i=s.length-1,j=t.length-1;i>-1 || j > -1;)
        {
            if((i > -1 && s[i] == '#') || (j > -1 && t[j] == '#'))
            {
            
                if(i > -1 && s[i] == '#')
                {
                    delS++;
                    i--;
                }
                if(j > -1 && t[j] == '#')
                {
                    delT++;
                    j--;
                }
            }else{
                if(delS > 0 || delT > 0)
                {
                    if(delS > 0)
                    {
                        delS--;
                        i--;
                    }
                    if(delT > 0)
                    {
                        delT--;
                        j--;
                    }
                }else{
                    if(i < 0)return false;
                    if(j < 0)return false;
                    if(s[i] != t[j])return false;
                    i--;j--;
                }   
            }
        }
        return true;
    }
}
