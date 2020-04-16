class Solution {
    public boolean checkValidString(String s) {
        char[] str = s.toCharArray();
        int low = 0,up = 0;
        for(int i=0;i<str.length;i++)
        {
            if(str[i] == '('){low++;up++;}
            else if(str[i] == ')'){low--;up--;}
            else{low--;up++;}
            
            if(up < 0)break;
            low = Math.max(low,0);
        }
        return low == 0;
    }
}
