public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int n= nums.Length;
        HashSet<int> map = new HashSet<int>();
        for(int i=0;i<n;i++)
        {
            if(map.Contains(nums[i]))return true;
            map.Add(nums[i]);
            if(i>=k)map.Remove(nums[i-k]);
        }
        return false;
    }
}
