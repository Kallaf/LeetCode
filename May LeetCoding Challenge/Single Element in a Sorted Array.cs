public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        int l=0,n=nums.Length,r=n;
        while(l<r)
        {
            int mid = l + (r-l)/2;
            if(mid+1 != n && nums[mid] == nums[mid+1])
            {
                if(mid%2==0)l = mid+1;
                else r = mid;
            }else if(mid-1 != -1 && nums[mid] == nums[mid-1])
            {
                if(mid%2==0)r = mid;
                else l = mid+1;
            }else return nums[mid];
        }
        return -1;
    }
}
