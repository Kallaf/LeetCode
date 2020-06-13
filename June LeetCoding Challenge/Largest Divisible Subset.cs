public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        if(nums.Length == 0)return new List<int>();
        Array.Sort(nums);
        int[] cnt = new int[nums.Length];
        int[] parent = new int[nums.Length];
        int mx_i=0;
        for(int i=0;i<nums.Length;i++)
        {
            cnt[i] = 1;parent[i] = i;
            for(int j=0;nums[j]<nums[i];j++)
            {
                if(nums[i]%nums[j] == 0){
                    if(cnt[j] >= cnt[parent[i]])
                    {
                        cnt[i] = cnt[j] + 1;
                        parent[i] = j;
                        if(cnt[i] > cnt[mx_i])
                            mx_i = i;
                    }
                }
            }   
            
        }
        List<int> res = new List<int>();
        int id = mx_i;
        while(parent[id] != id)
        {
            res.Add(nums[id]);
            id = parent[id];
        }
        res.Add(nums[id]);
        return res;
    }
}
