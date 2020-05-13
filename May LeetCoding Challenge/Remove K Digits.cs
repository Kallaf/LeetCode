public class Solution {
    public string RemoveKdigits(string num, int k) {
        bool[] ignore = new bool[num.Length];
        int start = 0,mn_i=0;
        String n = "";
        while(k > 0&&start<num.Length)
        {
            for(int i=start;i<num.Length&&i<=start+k;i++)
                if(num[i] < num[mn_i])mn_i = i;
            for(int i=start;i<num.Length&&i<mn_i;i++)
            {
                ignore[i] = true;
                k--;
            }
            mn_i++;
            start = mn_i;
        }
        for(int i=num.Length-1;i>=0&&k>0;i--)
        {
            if(num[i] != '0'&&!ignore[i])
            {
                ignore[i] = true;
                k--;
            }
        }
        bool leftZeros = true;
        for(int i=0;i<num.Length;i++)
        {
            if(num[i] != '0'&&!ignore[i])leftZeros = false;
            if(!leftZeros&&!ignore[i])n += num[i];
        }
        
        if(n == "")return "0";
        return n;
    }
}
