public class Solution {
    public int HIndex(int[] citations) {
        int n = citations.Length;
        int l=0,r=n-1;
        int ans = 0;
        while(l<=r)
        {
            int mid = l+ (r-l)/2;
            int h = n-mid;
            if(citations[mid] >= h)
            {
                r = mid-1;
                ans = h;
            }
            else
                l = mid+1;
        }
        return ans;
    }
}
