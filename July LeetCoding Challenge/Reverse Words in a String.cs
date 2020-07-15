public class Solution {
    public string ReverseWords(string s) {
        string[] arr = s.Split(new Char [] {' ', '\t' });
        string ans = "";
        for(int i=arr.Length-1;i>=0;i--)
            if(!arr[i].Equals(""))
            {
                if(ans != "")
                    ans += " ";
                ans += arr[i];
            }
        return ans;
    }
}
