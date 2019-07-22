public class Solution {
    public string ConvertToTitle(int n) {
        string reverse = "";
        while(n > 0)
        {
            n--;
            reverse +=(char) ('A' + n%26);
            n/=26;
        }
        string title = "";
        for(int i=reverse.Length-1;i>=0;i--)
            title += reverse[i];
        return title;
    }
}
