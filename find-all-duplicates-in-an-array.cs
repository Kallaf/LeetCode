public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        IList<int> ans = new List<int>();
        bool[] cnt = new bool[nums.Length];
        for(int i=0;i<nums.Length;i++)
        {
            if(cnt[nums[i]-1])
                ans.Add(nums[i]);
            else
                cnt[nums[i]-1] = true; 
            
        }
        return ans;
    }
}
